   M S B A M L   `   `   `  ����A  =School, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:School.ViewsSchool.Views  5   	       School.Views.Diriginte   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:School.Views     5   	     � Title$  	Diriginte��5   	   $	��450��6   $	��700��6(   .��5	      � .+�5
   
   �� -   5         ��Name$ clasaBoxDir��5
      $
��Left=�6(   $��
197,92,0,0q�6C   $	��Top=�6W   $	��101��6o   6{   �� 5   
   $��Clasa��6   $
��Left=�6    $��
197,61,0,0q�6;   $	��Top=�6O   $	��101��6g   �� 5   
   -   5        $ 
elevBoxDir��5      $
��Left=�6'   $��
381,92,0,0q�6B   $	��Top=�6V   $	��161��6n   6z   �� 5   
   $��Elevul��6   $
��Left=�6!   $��
381,61,0,0q�6<   $	��Top=�6P   $	��101��6h   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ gradeGridDir��5      $
��Left=�6)   $	��154��6D   $��
20,176,0,0q�6Q   $	��Top=�6e   $	��300��6}      
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Nota��69      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6G   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� 6G     5      $
 Data��69   $	 100 6G    6%   �� 6G     5      $
 Teza��69   $	 100 6G    6%   �� 6G   5        5   
   -   5        $ AbsenceGridDir��5      $
��Left=�6+   $	��154��6F   $��367,176,0,0q�6S   $	��Top=�6h   $	��300��6�    .    SelectionMode$ Single=�6�    5        5      $
 Data��69   $	 100 6G    6%   �� 6G     5      $ Materia��69   $	 100 6J    6%   �� 6J     5      $ Motivata��69   $	 100 6K    6%   �� 6K   5      �� 5   
   -   5        	 ��Name$	 addGradeDir��5      $��Adauga Nota��6&   $
��Left=�6<   $��226,351,0,0q�6W   $	��Top=�6l   $��94��6�   6�   �� 5   
   -   5        $	 	addAbsDir��5      $��Adauga Absenta��6$   $
��Left=�6=   $��555,350,0,0q�6X   $	��Top=�6m   $	��112��6�   6�   �� 5   
   -   5        $	 motivAbsDir��5      $��Motiveaza Absenta��6'   $
��Left=�6C   $��409,350,0,0q�6^   $	��Top=�6s   $	��118��6�   6�   �� 5    
   $��Media:��6   $
��Left=�6!   $��
20,350,0,0q�6<   $	��Top=�6P   $��69��6h   �� 5!   
   -   5        
 ��Name$
 avgDir��5!      $�� ��6    $
��Left=�6+   $��
94,350,0,0q�6F   $	��Top=�6Z   $��40��6r   �� 5"   
   $
��Note��6   $
��Left=�6   $��
20,145,0,0q�6:   $	��Top=�6N   $��69��6f   �� 5#   
   $��Absente��6   $
��Left=�6"   $��367,145,0,0q�6=   $	��Top=�6R   $��69��6j   5%      5&      