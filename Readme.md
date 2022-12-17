<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128649172/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1616)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# WPF Data Grid - Create a Custom Drop-down Filter

This example demonstrates how to create a custom drop-down filter for the **Index** column:

1. Set the column's [FilterPopupMode](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.ColumnBase.FilterPopupMode) property to **Custom**.
2. Create a drop-down filter template and assign it to the [CustomColumnFilterPopupTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.ColumnBase.CustomColumnFilterPopupTemplate) property.

![image](https://user-images.githubusercontent.com/65009440/174805719-a82cbb1a-db77-4678-8700-afd7df6fc49d.png)

You can use the **GetUniqueColumnValues** method if you need to obtain all unique values within a column:

```cs
var filterItems = grid.DataController.FilterHelper.GetUniqueColumnValues(columnInfo, -1, true, false, null);
```

<!-- default file list -->

## Files to look at

* [Window1.xaml](./CS/DXGrid_CustomFilterPopup/Window1.xaml) (VB: [Window1.xaml](./VB/DXGrid_CustomFilterPopup/Window1.xaml))
* [Window1.xaml.cs](./CS/DXGrid_CustomFilterPopup/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/DXGrid_CustomFilterPopup/Window1.xaml.vb))

<!-- default file list end -->

## Documentation

* [Custom Drop-down Filter](https://docs.devexpress.com/WPF/120532/controls-and-libraries/data-grid/filtering-and-searching/filter-dropdown/custom-drop-down-filter)
* [ColumnBase.CustomColumnFilterPopupTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.ColumnBase.CustomColumnFilterPopupTemplate)
* [TrackBarEdit](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.TrackBarEdit)

## More Examples

* [WPF Data Grid - Customize Items in a Column's Drop-down Filter](https://github.com/DevExpress-Examples/how-to-customize-filter-items-within-a-columns-filter-dropdown-e1533)
* [WPF Data Grid - Apply a Custom Filter Condition](https://github.com/DevExpress-Examples/how-to-implement-custom-filtering-e1167)
