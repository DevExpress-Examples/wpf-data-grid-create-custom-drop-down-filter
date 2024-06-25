<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128649172/11.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1616)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Window1.xaml](./CS/DXGrid_CustomFilterPopup/Window1.xaml) (VB: [Window1.xaml](./VB/DXGrid_CustomFilterPopup/Window1.xaml))
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


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-create-custom-drop-down-filter&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-create-custom-drop-down-filter&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
