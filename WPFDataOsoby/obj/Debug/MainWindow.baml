   M S B A M L   `   `   `  ����G  CWPFDataOsoby, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WPFDataOsobyWPFDataOsoby  5   	   O,clr-namespace:WPFDataOsoby.OperationsServiceWPFDataOsoby.OperationsService  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 6P       WPFDataOsoby.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WPFDataOsoby     5   	   JOperationsService,clr-namespace:WPFDataOsoby.OperationsService     5   	   9System&clr-namespace:System;assembly=mscorlib     6P   -   5          � Title$  Person Data��5	   	   $	��450��6   $	��800��6*    � 
ResizeMode$ NoResize=�5
   	   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��21* �6   �� 5      .+�5   
   �� -   5         ��Name$ 	AgeButton��5      $��Enter��6$   $
��Left=�64   $��
77,247,0,0q�6O   $	��Top=�6c   $	��107��6{   $��52��6�   �� 5   
   -   5         ��Name$ AgeText��5      $
��Left=�6#   $��36��6>   $��
77,195,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��107��6�    J� RenderTransformOrigin$ 
0.95,0.738&�6�   $��24(�6�    �� TextAlignment$ Center=�6�   .��6�    � DataContext 5      ��5      0��6"   .��5   #   5      �� 5   
   -   5        	 ��Name$	 
list_osoba��5      $��
279,0,10,0q�6'   $��2��6;   $��Disabled=�6O   
 �� View
 5      �� 5      .P�5      �� $��ID��6%    �� Width$ 20��61    �� DisplayMemberBinding 6<   �� *ID+�� 5      $
��Meno��6%   $	 100��63    6?   �� *Meno+�� 5      $��
Priezvisko��6%   $	 100��69    6E   �� *
Priezvisko+�� 5       $��DatumNarodenia��6%   $	 100��6=    6I   ��  �� Path$ DatumNarodenia� �� StringFormat$ 
yyyy-MM-dd���� 5!      $��Ulica��6%   $	 110��64    6@   �� *Adresa.Ulica+�� 5"      $��Cislo��6%   $ 30��64    6?   �� *Adresa.Cislo+�� 5#      $�� ��6%   $ 30��6/    �� CellTemplate 5$      �� 5%      .R�5&   "   �� -   5        $��Center=�5&   ,    d� 	IsChecked 6I   �� *
IsSelected+5'   +   5(      5*      5+      5-      �� 5.   
   $��
Enter age:��6   $
��Left=�6%   $��
77,148,0,0q�6@   $	��Top=�6T   $��42��6l   $	��118��6x   $��24(�6�   �� 5/   
   -   5        $��Write to .CSV��5/      $
��Left=�6C   $��
77,342,0,0q�6^   $	��Top=�6r   $	��107��6�   $��52��6�   $ 0.692,-0.796&�6�   �� 50   
   -   5        $��Read all data��50      $
��Left=�6C   $��52��6^   $��	77,81,0,0q�6j   $	��Top=�6}   $	��107��6�   �� 51   
   -   5        $��	Reconnect��51      $
��Left=�6%   $��52��6@   $��	77,10,0,0q�6L   $	��Top=�6_   $	��107��6w   6�   52      53      