using DevExpress.Data.Filtering;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Data;

namespace DXGrid_CustomFilterPopup {
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
            grid.ItemsSource = GridData.GetData();
        }
    }
    public class GridData {
        static public ObservableCollection<DataObject>  GetData() {
            ObservableCollection<DataObject> data = new ObservableCollection<DataObject>();
            for (int i = 0; i < 100; i++)
                data.Add(new DataObject() { Index = i });
            return data;
        }
    }
    public class DataObject {
        public int Index { get; set; }
    }
    public class IntToCriteriaOperatorConverter : IValueConverter {
        object IValueConverter.Convert(object value, Type targetType, 
                object parameter, System.Globalization.CultureInfo culture) {
            BinaryOperator binaryOperator = value as BinaryOperator;
            if (ReferenceEquals(binaryOperator, null))
                return null;
            OperandValue operandValue = binaryOperator.RightOperand as OperandValue;
            return operandValue.Value;
        }
        object IValueConverter.ConvertBack(object value, Type targetType,
                object parameter, System.Globalization.CultureInfo culture) {
            return new BinaryOperator("Index", Convert.ToInt32(value), BinaryOperatorType.GreaterOrEqual);
        }
    }
}
