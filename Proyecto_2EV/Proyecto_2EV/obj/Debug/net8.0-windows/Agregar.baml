   M S B A M L   `   `   `  ����G  CProyecto_2EV, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Proyecto_2EVProyecto_2EV  5          Proyecto_2EV.Agregar   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Proyecto_2EV     5        N� 
Background  �#242424 N� Title$ Agregar��5
      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��230 �6   6.   �� 5      6!    � RowDefinitions 5   
   �� 5      $	��64* �6   6+   �� 5      $
��278* �6   6,   �� 5      $
��183* �6   6,   .+�5   
   � $��1��6   $
��Left=�6$   $��15,0,0,0q�6?   $	��500��6Q   $��Center=�6]   $��34��6x   .+�5      �� $��23(�6   $
��Bold"�6&   ���#5DB85B$��	0,0,340,0q�6M   	Agregar6j   � 5      $��Right=�6   $��60��64   $��0,10,0,0q�6?   .+�5      �� -   5        $G��AC:\Users\migue\Downloads\Img_Proyecto2EV_Interfaces\minimizar.png��5      $��17��6c   $��Center=�6n   $��10,0,7,0q�6�   6�   �� 5      -   5        $D��>C:\Users\migue\Downloads\Img_Proyecto2EV_Interfaces\cerrar.png��5      $��17��6`   6�   5      5!      �� 5#   
   $��1��6   $��1��6%   $��Center=�62   $	��Top=�6O   $	��250��6g   .+�5$      �� $	��250��6   $
��Auto=�6(   .��5%      &   System.Windows.Controls.DataGrid  -   5        $��tabla��5%         HeadersVisibility$ Column=�6(   ���#242424$��19(�6X   $
��Bold"�6f   ���#242424   
IsReadOnly$
 True��6�      AutoGenerateColumns$
 True��5&      $
��True��6-      ColumnHeaderStyle 5(      �� 5)       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6    .�5*      �� 	 �� Property	 � ��
 �� Value
 �#2424246;   �� 5+      	 � ��
 �#5DB85B6;   5,         	CellStyle 5/      �� 50      *  $System.Windows.Controls.DataGridCell"  6    .�51      �� 	 � ��
 �#2424246;   �� 52      	 � ��
 �#5DB85B6;   �� 53      	 � ��
 �#2424246<   �� 54      	 � ��$
 10q�6@   55      57      58      59      �� 5;   
   $��1��6   $��2��6%   $
��Left=�62   $��20,0,0,0q�6M   $��Center=�6_   $	��162��6z   $	��380��6�   .+�5=      �� $��61��6   $
��Left=�6%   .+�5>      �� $
��Bold"�6   $��16(�6.   ���#5DB85B$��0,0,0,5q�6Q   	Producto:6m   �� 5?      -   5         ��Name$ nombreProducto��5?   z   ���#242424���#5DB85B$��15(�6D   $
��Bold"�6R   ���#242424$	��380��6�   $��20��6�   �� 5@      $D��>C:\Users\migue\Downloads\Img_Proyecto2EV_Interfaces\Line 1.png��6   $	��373��6`   $��10��6l   6z   5A      �� 5C      $��93��6   $
��Left=�6%   .+�5D      �� $
��Bold"�6   $��16(�6.   ���#5DB85B$��0,0,0,5q�6Q   
Categoria:6n   �� 5E      -   5        $ 	Categoria��5E   {   ���#242424���#5DB85B$��15(�6E   $
��Bold"�6S   ���#242424$	��380��6�   $��20��6�   �� 5F      $D��>C:\Users\migue\Downloads\Img_Proyecto2EV_Interfaces\Line 1.png��6   $	��373��6`   $��10��6l   6z   �� 5I      -   5         ��Name$ BotonAgregar��5I   C   $��0,10,0,0q�6   $	��100��6+   $��25��67   ���#5DB85B���#242424$
��Bold"�6�   ���#242424$��16(�6�   $��Agregar��6�   $
��Left=�6�   ��5J      �� 5K       �� 
TargetType" ��6*   .R�5L      ��  �� CornerRadius$ 10��6%   #��z��67   ._�5M   "   �� $��Center=�63   $��Center=�6P   5N      5O      5Q      5R      5V      5Y      5Z      