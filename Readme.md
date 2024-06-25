<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128641884/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5161)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# WPF MVVM Behaviors - Create a Custom Attached Behavior

Each Behavior is a **Behavior&lt;T&gt;** class descendant. The **T** parameter defines the associated control type.

The **Behavior&lt;T&gt;** class contains the **AssociatedObject** property. DevExpress MVVM Framework specifies this property when you add a Behavior to the Behaviors collection. 

After the AssociatedObject is specified, DevExpress MVVM Framework invokes the virtual **OnAttached** method. You can override this method to subscribe to AssociatedObject's events and initialize its properties. 

To unsubscribe from events, you can use the virtual **OnDetaching** method. DevExpress MVVM Framework invokes when the Behavior is destroyed.

<!-- default file list -->
## Files to Look At

* [ValidationBehavior.cs](./CS/Behaviors/ValidationBehavior.cs) (VB: [ValidationBehavior.vb](./VB/Behaviors/ValidationBehavior.vb))
* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MainWindow.xaml.vb))
* [MainView.xaml](./CS/View/MainView.xaml) (VB: [MainView.xaml](./VB/View/MainView.xaml))
* [MainView.xaml.cs](./CS/View/MainView.xaml.cs) (VB: [MainView.xaml.vb](./VB/View/MainView.xaml.vb))
* [MainViewModel.cs](./CS/ViewModel/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/ViewModel/MainViewModel.vb))
<!-- default file list end -->

## Documentation

- [Behaviors](https://docs.devexpress.com/WPF/17442/mvvm-framework/behaviors)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-mvvm-behaviors-create-a-custom-behavior&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-mvvm-behaviors-create-a-custom-behavior&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
