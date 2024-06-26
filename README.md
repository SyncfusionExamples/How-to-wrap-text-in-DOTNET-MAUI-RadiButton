# How-to-wrap-text-in-.NET-MAUI-RadiButton
This repository contains a sample demonstrating of wrapping text using LineBreakMode property in .NET MAUI RadiButton.

## LineBreakMode support in .NET MAUI RadiButton (SfRadiButton)
The LineBreakModeSupport feature enables flexible text truncation and wrapping options within user interface components, enhancing readability and presentation. It facilitates various modes like WordWrap, CharacterWrap, MiddleTruncation, etc., accommodating diverse layout requirements efficiently.

The following code example illustrate how to set LineBreakMode in SfRadiButton.

**XAML**
```
  <syncfusion:SfRadioButton Text="By clicking here, I state that I have read and understood the terms and conditions." LineBreakMode="WordWrap"/>
  <syncfusion:SfRadioButton Text="By clicking here, I state that I have read and understood the terms and conditions." LineBreakMode="CharacterWrap"/>
  <syncfusion:SfRadioButton Text="By clicking here, I state that I have read and understood the terms and conditions." LineBreakMode="HeadTruncation"/>
  <syncfusion:SfRadioButton Text="By clicking here, I state that I have read and understood the terms and conditions." LineBreakMode="MiddleTruncation"/>
  <syncfusion:SfRadioButton Text="By clicking here, I state that I have read and understood the terms and conditions." LineBreakMode="TailTruncation"/>
  <syncfusion:SfRadioButton Text="By clicking here, I state that I have read and understood the terms and conditions." LineBreakMode="NoWrap"/>

```

**C#**
```
   SfRadioButton radioButton = new SfRadioButton();
        radioButton.Text = "By clicking here, I state that I have read and understood the terms and conditions.";
	radioButton.LineBreakMode = "WordWrap"; 

```
