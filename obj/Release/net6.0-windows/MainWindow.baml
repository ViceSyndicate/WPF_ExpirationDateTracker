   M S B A M L   `   `   `  ���� T  PWPF_ExpirationDateTracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:WPF_ExpirationDateTrackerWPF_ExpirationDateTracker  *    $WPF_ExpirationDateTracker.MainWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     9local'clr-namespace:WPF_ExpirationDateTracker     $��18(�  � Title$  
MainWindow��$	��450��$	��800��.��� $��1,0,-1,0q� � ColumnDefinitions �� $��20 ��� $
��auto ��� $
��auto ��� $
��auto ��� $��* ��� $��20 � � RowDefinitions �� $��20 ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $��* ��� $��20 �.+��� $��1��$��1��$��24(�$��Expiration Date Tracker��$��4��$��0,0,0,20q��� $��1��$��2��$��22(�$��Name:���� -    ��Name$
 name��$��2��$��2��$	��150���� $��1��$��3��$��22(�$��Date:��$��0,10,0,0q�(  "System.Windows.Controls.DatePicker  -     Name$
 date��$��2��$��3��$��18(�   Text$ Date:��$��0,10,0,0q��� -    ��Name$ submitButton��$��1��$��4��$��2��$��0,10,0,0q�$��	Save Food��
�������� -   $ deleteButton��$��1��$��5��$��2��$��0,10,0,0q�$��Delete Food��
���<��&   System.Windows.Controls.DataGrid  -     Name$ productGrid��$��4��$��2��$��6��   AlternatingRowBackground
 �����$��
10,0,10,10q�	   SelectionUnit$	 FullRow=�
   SelectionMode$
 Single=�   CanUserResizeRows$ False��   CanUserAddRows$ False��   CanUserDeleteRows$ False��   AutoGenerateColumns$ False��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Expiry Date��   Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *ExpirationDate+ �� StringFormat$ d��  $
 Name��$
 100*  �� *Name+