   M S B A M L   `   `   `  ����A  =School, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:School.ViewModelsSchool.ViewModels  5   	   5clr-namespace:School.ConvertersSchool.Converters  5   	   +clr-namespace:School.ViewsSchool.Views  5   	       School.Views.Profesor   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   /ctxclr-namespace:School.ViewModels     5   	   3convertclr-namespace:School.Converters     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:School.Views     5   	     � Title$  Profesor��5
   	   $	��450��6   $	��700��6'    � DataContext 5      "   School.ViewModels.ProfesorVM  5   
   .��5      � .+�5   
   �� -   5         ��Name$ clasaBox��5      $
��Left=�6%   $��
197,92,0,0q�6@   $	��Top=�6T   $	��101��6l   6x   �� 5   
   $��Clasa��6   $
��Left=�6    $��
197,61,0,0q�6;   $	��Top=�6O   $	��101��6g   �� 5   
   -   5        $ elevBox��5      $
��Left=�6$   $��
381,92,0,0q�6?   $	��Top=�6S   $	��161��6k   6w   �� 5   
   $��Elevul��6   $
��Left=�6!   $��
381,61,0,0q�6<   $	��Top=�6P   $	��101��6h   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	gradeGrid��5      $
��Left=�6&   $	��154��6A   $��
20,176,0,0q�6N   $	��Top=�6b   $	��300��6z      
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Nota��69      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6G   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� 6G     5      $
 Data��69   $	 100 6G    6%   �� 6G     5      $
 Teza��69   $	 100 6G    6%   �� 6G   5        5   
   -   5        $ AbsenceGrid��5      $
��Left=�6(   $	��154��6C   $��367,176,0,0q�6P   $	��Top=�6e   $	��300��6}    .  5        5      $
 Data��69   $	 150 6G    6%   �� 6G     5      $ Motivata��69   $	 150 6K    6%   �� 6K   5      �� 5    
   -   5        	 ��Name$	 addGrade��5       $��Adauga Nota��6#   $
��Left=�69   $��226,351,0,0q�6T   $	��Top=�6i   $��94��6�   6�   �� 5!   
   -   5        $	 addAbs��5!      $��Adauga Absenta��6!   $
��Left=�6:   $��555,350,0,0q�6U   $	��Top=�6j   $	��112��6�   6�   �� 5"   
   -   5        $	 motivAbs��5"      $��Motiveaza Absenta��6$   $
��Left=�6@   $��409,350,0,0q�6[   $	��Top=�6p   $	��118��6�   6�   �� 5$   
   $��Media:��6   $
��Left=�6!   $��
20,350,0,0q�6<   $	��Top=�6P   $��69��6h   �� 5%   
   -   5        
 ��Name$
 avgProf��5%      $�� ��6!   $
��Left=�6,   $��
94,350,0,0q�6G   $	��Top=�6[   $��40��6s   �� 5&   
   $
��Note��6   $
��Left=�6   $��
20,145,0,0q�6:   $	��Top=�6N   $��69��6f   �� 5'   
   $��Absente��6   $
��Left=�6"   $��367,145,0,0q�6=   $	��Top=�6R   $��69��6j   5)      5*      