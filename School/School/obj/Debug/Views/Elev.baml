   M S B A M L   `   `   `  ����A  =School, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:School.ViewsSchool.Views  5   	       School.Views.Elev   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:School.Views     5   	     � Title$
  Elev��5   	   $	��450��6   $	��700��6#   .��5	      � .+�5
   
   �� -   5         ��Name$ subjectElev��5
      $
��Left=�6(   $	��Top=�6C   $	��120��6[   $��	64,94,0,0q�6g   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ gradeGridElev��5      $
��Left=�6*   $	��154��6E   $��
20,176,0,0q�6R   $	��Top=�6f   $	��300��6~      
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Nota��69      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6G   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� 6G     5      $
 Data��69   $	 100 6G    6%   �� 6G     5      $
 Teza��69   $	 100 6G    6%   �� 6G   5        5   
   -   5        $ absenceGridElev��5      $
��Left=�6,   $	��154��6G   $��367,176,0,0q�6T   $	��Top=�6i   $	��300��6�    .  5        5      $
 Data��69   $	 150 6G    6%   �� 6G     5      $ Motivata��69   $	 150 6K    6%   �� 6K   5      �� 5   
   $��Media:��6   $
��Left=�6!   $��
20,350,0,0q�6<   $	��Top=�6P   $��69��6h   �� 5   
   -   5         ��Name$ avgElev��5      $�� ��6!   $
��Left=�6,   $��
94,350,0,0q�6G   $	��Top=�6[   $��40��6s   �� 5   
   $��Materia��6   $
��Left=�6"   $��	64,63,0,0q�6=   $	��Top=�6P   $��70��6h   �� 5   
   $
��Note��6   $
��Left=�6   $��
20,145,0,0q�6:   $	��Top=�6N   $��69��6f   �� 5   
   $��Absente��6   $
��Left=�6"   $��367,145,0,0q�6=   $	��Top=�6R   $��69��6j   5      5      