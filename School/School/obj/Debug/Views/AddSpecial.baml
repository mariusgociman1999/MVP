   M S B A M L   `   `   `  ����A  =School, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:School.ViewModelsSchool.ViewModels  5   	   5clr-namespace:School.ConvertersSchool.Converters  5   	   +clr-namespace:School.ViewsSchool.Views  5   	       School.Views.AddSpecial   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /ctxclr-namespace:School.ViewModels     5   	   3convertclr-namespace:School.Converters     5   	   ,localclr-namespace:School.Views     5   	     � Title$  Adaugare Specializare��5
   	   $	��300��6'   $	��300��64    � DataContext 5      &    School.ViewModels.SpecializareVM  5   
   .��5      ��  � 	Resources 5   
   )  #School.Converters.SpecialConvertAdd   specConvertAdd��%   &	          5      6(   5      .+�5   
   �� $��Descriere Specializare��6   $
��Left=�61   $��	84,80,0,0q�6L   $	��Top=�6_   $	��131��6w   �� 5   
   -   5         ��Name$ DescSpec��5      $
��Left=�6$   $��23��6?   $��84,5,0,0q�6K    �� TextWrapping$
 Wrap=�6]   $	��Top=�6q   $	��120��6�   �� 5   
   -   5         ��Name$ AdSpec��5      $��Adauga��6!   $
��Left=�62   $��
104,20,0,0q�6M   $	��Top=�6a   $��75��6y   $��33��6�   ��6�   �� *
AddCommand+��5      `� 5       `� 	Converter# [  6   .1�5      ��  �� ElementName$ DescSpec��6    �� Path$
 Text�65   5      5      5      5      