   M S B A M L   `   `   `  ����G  CProyecto_2EV, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Proyecto_2EVProyecto_2EV  5          Proyecto_2EV.Modificar   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Proyecto_2EV     5        N� 
Background  �#242424 N� Title$ 	Modificar��5
      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��230 �6   6.   �� 5      6!    � RowDefinitions 5   
   �� 5      $	��64* �6   6+   �� 5      $
��216* �6   6,   �� 5      $
��245* �6   6,   .+�5   
   � $��1��6   $��0,0,0,0q�6$   $	��480��65   $��Center=�6A   $��34��6\   .+�5      �� $��25(�6   $
��Bold"�6&   ���#5DB85B$	��120��6M   $��	0,0,300,0q�6Y   	Modificar6x   � 5      $��60��6   $��0,10,0,0q�6#   .+�5      �� -   5        $G��AC:\Users\migue\Downloads\Img_Proyecto2EV_Interfaces\minimizar.png��5      $��17��6c   $��Center=�6n   $��10,0,7,0q�6�   6�   �� 5      -   5        $D��>C:\Users\migue\Downloads\Img_Proyecto2EV_Interfaces\cerrar.png��5      $��17��6`   6�   5       5"      �� 5$   
   $��1��6   $��1��6%   $��Center=�62   $��Center=�6O   .+�5%      �� $	��200��6   $
��Auto=�6(   .��5&      &   System.Windows.Controls.DataGrid  -   5        $��tabla��5&         HeadersVisibility$ Column=�6(   ���#242424$��19(�6X   $
��Bold"�6f   ���#242424   
IsReadOnly$
 True��6�      AutoGenerateColumns$
 True��5'      $
��True��6&      ColumnHeaderStyle 5)      �� 5*       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6    .�5+      �� 	 �� Property	 � ��
 �� Value
 �#2424246;   �� 5,      	 � ��
 �#5DB85B6;   5-         	CellStyle 50      �� 51      *  $System.Windows.Controls.DataGridCell"  6    .�52      �� 	 � ��
 �#2424246;   �� 53      	 � ��
 �#5DB85B6;   �� 54      	 � ��
 �#2424246<   �� 55      	 � ��$
 10q�6@   56      58      59      5:      �� 5<   
   $��1��6   $��2��6%   $
��Left=�62   $��20,0,0,0q�6M   $��Center=�6_   $	��380��6z   .+�5>      �� $��61��6   $
��Left=�6%   .+�5?      �� $
��Bold"�6   $��16(�6.   ���#5DB85B	Producto:6\   �� 5@      -   5         ��Name$ nombreProducto��5@   z   ���#242424���#5DB85B$��15(�6D   $
��Bold"�6R   ���#242424$	��380��6�   $��20��6�   �� 5A      $D��>C:\Users\migue\Downloads\Img_Proyecto2EV_Interfaces\Line 1.png��6   $	��373��6`   $��10��6l   6z   5B      �� 5D      $
��Left=�6   $��0,0,0,15q�64   .+�5E      �� $
��Bold"�6   $��16(�6.   ���#5DB85B
Categoria:6]   �� 5F      -   5        $ 	Categoria��5F   {   ���#242424���#5DB85B$��15(�6E   $
��Bold"�6S   ���#242424$	��380��6�   $��20��6�   �� 5G      $D��>C:\Users\migue\Downloads\Img_Proyecto2EV_Interfaces\Line 1.png��6   $	��373��6`   $��10��6l   6z   5H      �� 5K      .+�5L      �� $
��Bold"�6   $��16(�6.   ���#5DB85BID:6V   �� 5M      -   5        $ ID��5M   {   ���#242424���#5DB85B$��15(�6E   $
��Bold"�6S   ���#242424$	��380��6�   $��20��6�   �� 5N      $D��>C:\Users\migue\Downloads\Img_Proyecto2EV_Interfaces\Line 1.png��6   $	��373��6`   $��10��6l   6z   5O      �� 5Q      .+�5R      �� -   5        $��0,10,0,0q�5R      $	��100��6+   $��25��67   ���#5DB85B���#242424$
��Bold"�6n   ���#242424$��16(�6�   $��	Modificar��6�   $
��Left=�6�   ��5S      �� 5T       �� 
TargetType" ��6*   .R�5U      ��  �� CornerRadius$ 10��6%   #��z��67   ._�5V   "   �� $��Center=�63   $��Center=�6P   5W      5X      5Z      5[      5^      5`      5a      