   M S B A M L   `   `   `  ����A  =School, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:School.ViewModelsSchool.ViewModels  5   	   5clr-namespace:School.ConvertersSchool.Converters  5   	   clr-namespace:SchoolSchool  5   	       School.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /ctxclr-namespace:School.ViewModels     5   	   3convertclr-namespace:School.Converters     5   	   &localclr-namespace:School     5   	     � Title$  Login��5
   	   $	��450��6   $	��450��6$    � DataContext 5        School.ViewModels.UserVM  5   
   .��5      ��  � 	Resources 5   
   #  School.Converters.UserConvert   userConvert��%   &	          5      6"   5      .+�5   
   � .+�5      �� $�� School��6   $��Center=�6&   $��71��6C   $��135,39,127,0q�6O   $	��Top=�6e   $	��180��6}   $��48(�6�   5      � 5   
   $��75��6   .+�5      �� $��Username��6   $��Center=�6'   $��88��6D   $��30��6O   $��	75,30,0,0q�6[   �� 5      -   5         ��Name$ userBox��5      $
��Left=�6'   $��23��6B   $��0,30,0,0q�6N    �� TextWrapping$
 Wrap=�6`   $�� ��6t   $	��180��6|   5      � 5   
   $��75��6   .+�5      �� $��Password��6   $
��Left=�6'   $��	75,25,0,0q�6B   $	��Top=�6U   $��88��6m   �� 5      -   5        $ passBox��5      $
��Left=�6'   $��23��6B   $��2,25,0,0q�6N   $	��Top=�6`   $	��180��6x   .��6�    J� Effect 5      -  'System.Windows.Media.Effects.BlurEffect  5         Radius$ 10Q�6!   .��5   "   5       5!      � 5"   
   $��50��6   .+�5#      �� $��Login��6   $
��Left=�6%   $��21��6@   $��
180,20,0,0q�6L   $	��Top=�5$      $��91��6)   ��64   �� *CheckCommand+��5%      `� 5&       `� 	Converter# [  6#   .1�5'      ��  �� ElementName$ userBox��6"   	 �� Path$
	 Text�68   �� 5(      $ passBox��6"   $
	 Text�68   5)      5+      5,      5-      5.      