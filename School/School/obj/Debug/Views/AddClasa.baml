   M S B A M L   `   `   `  ����A  =School, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:School.ViewModelsSchool.ViewModels  5   	   5clr-namespace:School.ConvertersSchool.Converters  5   	   +clr-namespace:School.ViewsSchool.Views  5   	       School.Views.AddClasa   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /ctxclr-namespace:School.ViewModels     5   	   3convertclr-namespace:School.Converters     5   	   ,localclr-namespace:School.Views     5   	     � Title$  Adaugare Clasa��5
      $	��300��6   $	��400��6,    � DataContext 5         School.ViewModels.ClasaVM  5   
   .��5      ��  � 	Resources 5   
   '  !School.Converters.ClasaConvertAdd   classConvert��%   &	          5      6&   5      .+�5   
   � $��75��6   .+�5      �� $��Specializare��6   $
��Left=�6+   $��	70,20,0,0q�6F   $	��Top=�6Y   $��92��6q   �� 5      -   5         ��Name$ SpecAddClasa��5      $
��Left=�6-   $��0,20,0,0q�6H   $	��Top=�6Z   $	��120��6r    �� DisplayMemberPath$ 	Descriere��6�   ��6~   �� *
SpecList+ �� SelectedValue 6�   �� *IdSpecializare+6�   5      � 5   
   $��75��6   .+�5      �� $��Descriere Clasa��6   $
��Left=�6.   $��	50,20,0,0q�6I   $	��Top=�6\   $	��107��6t   �� 5      -   5         ��Name$ DescClasaBox��5      $
��Left=�6,   $��23��6G   $��	10,20,0,0q�6S    �� TextWrapping$
 Wrap=�6f   $	��Top=�6z   $	��120��6�   5      � 5   
   $��75��6   .+�5      �� -   5         ��Name$ AddClass��5      $��Adauga��6'   $
��Left=�68   $��
155,20,0,0q�6S   $	��Top=�6g   $��75��6   $��33��6�   ��5      �� *
AddCommand+��5      `� 5      	 `� 	Converter#	 [  6#   .1�5       �� 
 �� ElementName$
 DescClasaBox��6"    �� Path$
 Text�6=   �� 5!      $
 SpecAddClasa��6"   $ SelectedValue�6=   5"      5$      5%      5&      5'      