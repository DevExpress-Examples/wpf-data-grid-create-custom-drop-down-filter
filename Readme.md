<!-- default file list -->
*Files to look at*:

* [Window1.xaml](./CS/DXGrid_CustomFilterPopup/Window1.xaml) (VB: [Window1.xaml.vb](./VB/DXGrid_CustomFilterPopup/Window1.xaml.vb))
* [Window1.xaml.cs](./CS/DXGrid_CustomFilterPopup/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/DXGrid_CustomFilterPopup/Window1.xaml.vb))
<!-- default file list end -->
# How to Create a Custom Filter Dropdown


<p>This example demonstrates how to create a custom filter dropdown for the 'Index' column. To implement the required task, do the following:</p>
<p>1. Set the column's FilterPopupMode property to FilterPopupMode.Custom. <br /> 2. Create a template representing the required filter dropdown and assign it to the CustomColumnFilterPopupTemplate property.<br /><br /></p>
<p>If it's necessary to get all unique values in a column, the GetUniqueColumnValues method can be used:</p>


```cs
var filterItems = gridControl1.DataController.FilterHelper.GetUniqueColumnValues(columnIndex, -1, true, false, null);
```



<br/>


