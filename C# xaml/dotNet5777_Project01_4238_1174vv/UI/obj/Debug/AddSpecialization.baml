   M S B A M L   `   `   `  ����=  9UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:UIUI  5   	   = 9BE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BE;assembly=BEBE 5   	       UI.AddSpecialization   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:UI     5   	   +BEclr-namespace:BE;assembly=BE     5   	     � Title$  AddSpecialization��5	   	   $��239.25��6#   $��665.7��63   .��5
      � .+�5   
   �� -   5         ��Name$ button��5      $	��ADD��6"   
�������
���   �$��30(�6U   $
��Left=�6d   $��
22,146,0,0q�6   $	��Top=�6�   $��76��6�   $��52��6�   6�   �� 5   
   -   5        $ button1��5      $
��Left=�6"   $��596,146,0,0q�6=   $	��Top=�6R   $��52��6j   $��52��6u   ��5      �� 5       �� Orientation$ 
Horizontal=�6   .+�5      �� $��image/GoBack.png��6   $��48��66   $��49��6A   5      5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ specializationDataGrid��5         
IsReadOnly .    AutoGenerateColumns .     EnableRowVirtualization . $��268,0,47,78q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   ��6�   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        expertiseDomainColumn��,  &System.Windows.Controls.DataGridColumn	   Header$	 Expertise Domain��5   h   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 SizeToHeader 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *ExpertiseDomain+6�     5      -   5        maxTarifColumn��$	 	max Tarif��5   Z   $
 SizeToHeader 6m    6=   �� *
maxTarif+6m     5      -   5        minTarifColumn��$	 	min Tarif��5   Z   $
 SizeToHeader 6m    6=   �� *
minTarif+6m     5      -   5        specializationNumberColumn��$	 specialization Number��5   r   $
 SizeToHeader 6�    6I   �� *specializationNumber+6�   5      � 5   
   -   5         �Name$ grid3��5      $
��Left=�6   $��0,2,0,0q�69   $	��Top=�6J    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#    � RowDefinitions 5       �� 5!      $
��Auto �6    �� 5"      $
��Auto �6    �� 5#      $
��Auto �6    �� 5$      $
��Auto �6    .+�5&      �� $��Expertise Domain:��6   
�������$��0��6B   $
��Left=�6R   $��3q�6m   $��0��6x   $��Center=�6�   �� 5'      -	   5         ��Name$ expertiseDomainComboBox1��5'      $��1��69   $
��Left=�6J   $
��Auto��6e   $��3q�6�   $��0��6�   $��Center=�6�   $	��120��6�    �� SelectedItem 6s   �� *ExpertiseDomain+6�   �� 5(      $��
max Tarif:��6   
�������$��0��6;   $
��Left=�6K   $��3q�6f   $��1��6q   $��Center=�6~   �� 5)      -
   5         ��Name$ maxTarifTextBox1��5)      $��1��60   $
��Left=�6@   $��23��6[   $��3q�6g   $��1��6r   $��Center=�6�   $	��120��6�   ��6   �� *
maxTarif+ �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 6�   �� 5*      $��
min Tarif:��6   
�������$��0��6;   $
��Left=�6K   $��3q�6f   $��2��6q   $��Center=�6~   �� 5+      -   5        $ minTarifTextBox1��5+      $��1��60   $
��Left=�6@   $��23��6[   $��3q�6g   $��2��6r   $��Center=�6�   $	��120��6�   ��6   �� *
minTarif+$ TwoWay=� .  . 6�   �� 5,      $��specialization Number:��6   
�������$��0��6G   $
��Left=�6W   $��3q�6r   $��3��6}   $��Center=�6�   �� 5-      -   5        $" specializationNumberTextBox1��5-      $��1��6<   $
��Left=�6L   $��23��6g   $��3q�6s   $��3��6~   $��Center=�6�   $	��120��6  ��6�   �� *specializationNumber+$ TwoWay=� .  . 6  5.      ��50   
   �� 51      -   5        	image�� �� ImageSource$$ image/téléchargement (2).jpg��51   *   53      54      