using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Markup;
using DevExpress.Data.Filtering;

namespace DXGrid_CustomFilterPopup {
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
            grid.DataSource = GridData.GetData();
        }
    }
    public class GridData {
        static public List<DataObject>  GetData() {
            List<DataObject> data = new List<DataObject>();
            for (int i = 0; i < 100; i++)
                data.Add(new DataObject() { Index = i });
            return data;
        }
    }
    public class DataObject {
        public int Index { get; set; }
    }
    public class IntToCriteriaOperatorConverter : MarkupExtension, IValueConverter {
        public override object ProvideValue(IServiceProvider serviceProvider) {
            return this;
        }
        #region IValueConverter Members
        object IValueConverter.Convert(object value, Type targetType, 
                object parameter, System.Globalization.CultureInfo culture) {
            BinaryOperator op = value as BinaryOperator;
            if (object.ReferenceEquals(op, null))
                return null;
            OperandValue operandValue = op.RightOperand as OperandValue;
            return operandValue.Value;
        }
        object IValueConverter.ConvertBack(object value, Type targetType,
                object parameter, System.Globalization.CultureInfo culture) {
            return new BinaryOperator("Index", Convert.ToInt32(value), BinaryOperatorType.Greater);
        }
        #endregion
    }
}
