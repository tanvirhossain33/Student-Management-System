   M S B A M L   `   `   `  ����R  NStudentManagementSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:StudentManagementSystem.ViewStudentManagementSystem.View  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      _4clr-namespace:StudentManagementSystem.Infrastructure&StudentManagementSystem.Infrastructure  5      4    .StudentManagementSystem.View.StudentCollection   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:StudentManagementSystem.View     5      9system&clr-namespace:System;assembly=mscorlib     5      Oinfrastructure4clr-namespace:StudentManagementSystem.Infrastructure     5        � 	Resources  5       �� 
TargetType �� Property �� Value   DepartmentEnum S� 
MethodName S� 
ObjectType  System.Enum S� MethodParameters M� TypeName��%�  '��       '�� �     '��      &	  V    �� 5   
   " ��6   �5      �� 5       � ��$ 3q�6+   67   �� 5       � ��$
 Left=�68   6G   5      �� 5   
   " ��6   �5      �� 5       � ��$ 80��6*   67   �� 5       � ��$ 3q�6+   67   5      �� 5   
   " ��6   �5      �� 5       � ��$ 3q�6+   67   5      S� 5   
   $ 	GetValues��64   "  6K    5      M� 5      $ infrastructure:Department��6   5!      5"      .��5#      �  � RowDefinitions 5$   
   �� 5%      $
��Auto �6   6,   �� 5&      $
��Auto �6   6,   �� 5'      $
��Auto �6   6,   .+�5)   
   &   System.Windows.Controls.DataGrid  $��0��6   ��6    �� *StudentCollection+	 �� SelectedItem	 5*      �� *SelectedStudent+
 �� Mode$
 TwoWay=�6J   � 5+   
   $��1��6    � DataContext 6   �� *SelectedStudent+ 5,      �� 5-      $
��Auto �6    60   �� 5.      $
��Auto �6    60    � ColumnDefinitions 50      �� 51      $
��Auto �6#   62   �� 52      $
��Auto �6#   62   �� 53      $
��Auto �6#   62   �� 54      $
��Auto �6#   62   �� 55      $
��Auto �6#   62   .+�58      �� $��0��6   $��0��6%   $��
First Name��65   6I   �� 59      $��0��6   $��1��6%   $��	Last Name��65   6H   �� 5:      $��0��6   $��2��6%   $��
Student Id��65   6I   �� 5;      $��0��6   $��3��6%   $
��City��65   6C   �� 5<      $��0��6   $��4��6%   $��
Department��65   6I   �� 5>      $��1��6   $��0��6#   ��63   �� *	FirstName+6P   �� 5?      $��1��6   $��1��6#   ��63   �� *
LastName+6O   �� 5@      $��1��6   $��2��6#   ��63   �� *	StudentId+6P   �� 5A      $��1��6   $��3��6#   ��63   �� *CityOfResidence+6V   �� 5B      $��1��6   $��4��6$   	 64   �� *
Department+��5C      ��  �� Source# [  6X   5D      �� 5E   
   $��2��6    �� Orientation$ 
Horizontal=�6"   $��Right=�6;   .+�5F      �� $��Reset��6/   ��6   �� *Reset+6A   �� 5G      $��Save or Update��6.   ��6   �� *Save+6I   �� 5H      $��Delete��60   ��6   �� *Delete+6C   5I      5J      5K      