   M S B A M L   `   `   `  ����A  =School, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:School.ViewsSchool.Views  5   	       School.Views.ModProfCombo   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:School.Views     5   	     � Title$  ModProfCombo��5   	   $	��450��6   $	��800��6+   .��5	      � .+�5
   
   �� -   5         ��Name$ 	ClasaProf��5
      $
��Left=�6&   $��
74,249,0,0q�6A   $	��Top=�6U   $	��120��6m   �� 5   
   $��Clasa��6   $
��Left=�6    $��26��6;   $��
74,218,0,0q�6G   $	��Top=�6[   $��48��6s    J� RenderTransformOrigin$ 
-0.188,0.5&�6~   �� 5   
   -   5         ��Name$ profDir��5      $��Este Diriginte��6$   $
��Left=�6=   $��454,249,0,0q�6X   $	��Top=�6m   �� 5   
   $��Materia��6   $
��Left=�6"   $��26��6=   $��264,218,0,0q�6I   $	��Top=�6^   $��74��6v   �� 5   
   -   5        $ SubjProf��5      $
��Left=�6%   $��264,249,0,0q�6@   $	��Top=�6U   $	��120��6m   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	clasaGrid��5      $
��Left=�6&   $��75��6A   $��201,110,0,0q�6M   $	��Top=�6b   $	��300��6z      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Clasa��69      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� 6H     5      $ Materie��69   $	 100 6J    6%   �� 6J     5      $ 	Diriginte��69   $	 100 6L    6%   �� 6L   5      �� 5   
   -   5        	 ��Name$	 AddCombo��5      $��Adauga Clasa/Materia��6#   $
��Left=�6B   $��604,249,0,0q�6]   $	��Top=�6r   $	��131��6�   �� 5   
   -   5        $	 delCombo��5      $��Sterge��6#   $
��Left=�64   $��539,142,0,0q�6O   $	��Top=�6d   $��75��6|   �� 5   
   -   5        $	 
ModifCombo��5      $��Modifica��6%   $
��Left=�68   $��46��6S   $��327,343,0,0q�6_   $	��Top=�6t   $	��150��6�   5      5      