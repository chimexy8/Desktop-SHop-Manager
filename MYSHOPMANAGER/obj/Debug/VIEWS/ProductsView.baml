   M S B A M L   `   `   `  ����H  DMYSHOPMANAGER, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:MYSHOPMANAGER.VIEWSMYSHOPMANAGER.VIEWS  5      &     MYSHOPMANAGER.VIEWS.ProductsView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:MYSHOPMANAGER.VIEWS     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  ProductsView��5
      .��5      �� .+�5   
   �� $��
 NEW STOCK��6   $��350 35 0 20 q�6'   $
��Bold"�6>    J� Opacity$	 0.5Q�6P   $��26.667(�6_   � 5   
   .+�5      �� $��19.66(�6   $
��Left=�6*   $��100,180,0,0q�6E   $��Amount��6[   $	��Top=�6i   �� 5      $��19.66(�6   $
��Left=�6)   $��
690,38,0,0q�6D   $��CHOOSE CATEGORY��6X   $	��Top=�6o    J� RenderTransformOrigin$ 0.434,1.084&�6�   �� 5      $��19.66(�6   $
��Left=�6)   $��	98,50,0,0q�6E   $��PRODUCT NAME��6X   $	��Top=�6l   $ -0.7,-0.843&�6�   �� 5      -   5         ��Name$ combo1��5      $��60 0 0 0q�6'   $��690,83,0,118q�6:   
������� �� DisplayMemberPath$ CategoryName��6�   ���	#FF2196F3 �� SelectedIndex$ 0��6�   $
��Left=�6�   $	��200��6�   $��25��6'  ��6c   �� *ProductCombo+6'  �� 5      -   5         ��Name$ 
amounttext��5      
�������$��10 0 0 0q�6=   ���	#FF2196F3$
��Left=�6g   $��23��6�   $��90,214,0,-25q�6�   $	��Top=�6�   $	��150��6�   �� 5      -   5        $ productnametext��5      
�������$��10 0 0 0q�6B   $��	93,88,0,0q�6U   ���	#FF2196F3$
��Left=�6   $��23��6�   $	��Top=�6�   $	��170��6�   $ 0.428,0.533&�6�   �� 5      -   5        $ productidtext��5      
���  ��$y�Hidden=�6>   $
��Left=�6R   $��23��6m   $��0,80,0,0q�6y   $	��Top=�6�   $��10��6�   �� 5      $��19.66(�6   $
��Left=�6*   $��420,180,0,0q�6E   $��Stock Quantity��6Z   $	��Top=�6p   �� 5      -   5        $ stockquantitytext��5      $��10 0 0 0q�61   
����������	#FF2196F3$
��Left=�6n   $��23��6�   $��410,214,0,-20q�6�   $	��Top=�6�   $	��150��6�   �� 5      -   5         ��Name$ 
savebutton��5      $
��Save��6)      MaterialDesignRaisedButton#��[  68   3  -MaterialDesignThemes.Wpf.ButtonProgressAssist   Value$ -1Q�5      	   IsIndicatorVisible	 . 
   IsIndeterminate
 . ���	#FF2196F3$
��Left=�5       $��710,193,0,-33q�68   $	��148��6O   6[   �� 5!      -   5        $ productcategorytext��5!      
���  ��$
��Left=�6D   $��23��6_   $��1150,88,0,0q�6k   $y�Hidden=�6�   $	��Top=�6�   $��10��6�   $��30 0 0 0q�6�   $ 0.271,2.333&�6�   �� 5"      -   5        $ Updatebutton��5"      $y�Hidden=�6+   $��Update��6?   $
��Left=�6P   $��37,288,0,-94q�6k   $	��Top=�6�   $��85��6�   6�   5#      �� 5%   
   $��SHOP PRODUCTS��6   $��350 80 0 30 q�6*   $
��Bold"�6@   $	 0.5Q�6S   $y�Visible=�6a   $��26.667(�6v   &   System.Windows.Controls.DataGrid  5&   
   -	   5          Name$ productGrid��5&      $	��780��6(   $
��Left=�64      CanUserAddRows .  $��	120 0 0 0q�6f      Columns 5(      4  .System.Windows.Controls.DataGridTemplateColumn  5)      ,  &System.Windows.Controls.DataGridColumn   Header$
 Edit��6)      CellTemplate 5*      �� 5+      .R�5,      �� -
   5        $
��Edit��5,   %   64   5-      5/        50      $ Delete��6)    51      �� 52      .R�53      �� -   5        $��Delete��53   %   $��Delete��66   6G   54      56         RowDetailsTemplate 59      �� 5:      5=      5?      5@      5A      