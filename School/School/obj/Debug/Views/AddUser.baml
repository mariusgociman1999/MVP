   M S B A M L   `   `   `  ����A  =School, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:School.ViewModelsSchool.ViewModels  5   	   5clr-namespace:School.ConvertersSchool.Converters  5   	   +clr-namespace:School.ViewsSchool.Views  5   	       School.Views.AddUser   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /ctxclr-namespace:School.ViewModels     5   	   3convertclr-namespace:School.Converters     5   	   ,localclr-namespace:School.Views     5   	     � Title$  Adauga Utilizator��5
   	   $	��300��6#   $	��400��60    � DataContext 5        School.ViewModels.UserVM  5   
   .��5      ��  � 	Resources 5   
   #  School.Converters.UserConvert   userConvert��%   &	          5      6"   5      .+�5   
   � $��50��6   .+�5      �� $��Persoana��6   $��Center=�6'   $��88��6D   $��30��6O   $��	65,10,0,0q�6[   �� 5      -   5         ��Name$ People��5      $
��Left=�6'   $��23��6B   $��0,10,0,0q�6N    �� Text$  ��6`   $	��180��6h   ��6t   �� *
PeopleList+��5      �� 5      .R�5      �� ��5      `� 5   "    �� StringFormat$ {0} {1}��6/   .1�5   &   ��  �� Path$
 Nume�6.   �� 5   &   $ Prenume�6.   5   #   5      5      5!      5"      � 5#   
   $��50��6   .+�5$      �� $	��Rol��6   $��Center=�6"   $��88��6?   $��30��6J   $��	65,10,0,0q�6V   �� 5%      -   5        $ Roluri��5%      $
��Left=�6'   $��23��6B   $��0,10,0,0q�6N   $  ��6`   $	��180��6h   5&      � 5'   
   $��50��6   .+�5(      �� $��Username��6   $��Center=�6'   $��88��6D   $��30��6O   $��	65,10,0,0q�6[   �� 5)      -   5         ��Name$ userBox��5)      $
��Left=�6'   $��23��6B   $��0,10,0,0q�6N    �� TextWrapping$
 Wrap=�6`   $�� ��6t   $	��180��6|   5*      � 5+   
   $��50��6   .+�5,      �� $��Password��6   $
��Left=�6'   $��	65,10,0,0q�6B   $	��Top=�6U   $��88��6m   �� 5-      -   5        $ passBox��5-      $
��Left=�6'   $��23��6B   $��2,10,0,0q�6N   $	��Top=�6`   $	��180��6x   .��6�   	 J� Effect	 5.      -  'System.Windows.Media.Effects.BlurEffect  5/      
   Radius$
 10Q�6!   .��50   "   51      52      � 53   
   $��50��6   .+�54      �� $��Adauga��6   $
��Left=�6&   $��21��6A   $��
150,20,0,0q�6M   $	��Top=�55      $��91��6)   ��64   �� *
AddCommand+��56      `� 57       `� 	Converter# [  6#   .1�58      ��  �� ElementName$ userBox��6"   $
 Text�68   �� 59      $ passBox��6"   $
 Text�68   5;      5=      5>      5?      5@      