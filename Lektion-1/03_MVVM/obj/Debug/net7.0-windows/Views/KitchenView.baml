   M S B A M L   `   `   `  ????B  >03_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:_03_MVVM.Views_03_MVVM.Views  5      9!clr-namespace:_03_MVVM.Components_03_MVVM.Components  5           _03_MVVM.Views.KitchenView   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:_03_MVVM.Views     5      8
components!clr-namespace:_03_MVVM.Components     5      .??5
      ?? ??5   
   ?? 5        ?? Opacity$
  0.45Q?6    ?? ImageSource$! /Assets/Images/kitchen.jpeg??6(   ._?5   
   ? $??30q?6    ? RowDefinitions 5      ?? 5      $
??auto ?6    ?? 5      $??* ?6    .+?5      ? $??0??6   $??0 0 0 50q?6     ? ColumnDefinitions 5      ?? 5      $??1* ?6'   ?? 5      $??2* ?6'   ?? 5      $??1* ?6'   .+?5      ?? $??0??6    ?? Orientation$ 
Horizontal=?6-   $
??Left=?6F   $	??Top=?6a   .+?5      ??    FontAwesome-Regular#??[  6I   $??46(?6{   $??0 0 15 0q?6?   
?????????6    ?? *CurrentWeatherCondition+6?   ?? 5      $??22(?6    
???????$
??Left=?6E   $??Center=?6`   ?? 5      $??32(?6B   ?6   ?? *CurrentTemperature+6B    ?? 5       $	?°C??6   5!      5"      ?? 5$      $??1??6   $??Center=?6-   $	??Top=?6J   $??	0 -15 0 0q?6b   .+?5%      ?? $??52(?6=   
???????$??Center=?6b   $	??Top=?6   ??6    ?? *CurrentTime+6   ?? 5&      $??20(?6=   
???????$??Center=?6b   ??6    ?? *CurrentDate+6b   5'      ?? 5)      $??2??6   $	????6)   $??Segoe MDL2 Assets)?6<   $??32(?6\   
?????? 
???????$??0q?6?   $??Right=?6?   $	??Top=?6?   5+      ?? 5-      -   5         ??Name$ lv_Tiles??5-      $??1??6Q   
?????? $??0q?6w   $??Stretch=?6?   ??6-   ?? *DeviceItems+??5.      ?? 5/      .R?50      $   _03_MVVM.Components.DeviceTile     	IsChecked 51      ?? *DeviceState+   
DeviceName 52      ?? *
DeviceName+   
DeviceType 53      ?? *
DeviceType+	   
IconActive	 54      ?? *
IconActive+
   IconInActive
 55      ?? *IconInActive+56      ??58      ?? 59      .R?5:      ? ??6$   ?? *ActualWidth+ ?? ElementName$ lv_Tiles??5;      5=      5?      5B      5C      