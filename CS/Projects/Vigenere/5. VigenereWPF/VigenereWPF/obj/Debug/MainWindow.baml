   M S B A M L   `   `   `  ����F  BVigenereWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:VigenereWPFVigenereWPF  5   	       VigenereWPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:VigenereWPF     5   	     � Title$  Vigenere WPF Form��5   	   $��322.103��6#   $��479.009��64    � 
ResizeMode$ NoResize=�6D   .��5	      � $��
0,0,-8,-21q�6    � ColumnDefinitions 5
   
   �� 5       � RowDefinitions 5   
   �� 5      .+�5   
   �� -   5         ��Name$ 	btnSubmit��5      $��Submit��6$   $
��Left=�65   $��50��6P   $��102,224,0,0q�6\   $	��Top=�6q   $	��170��6�   $��16(�6�   �� 5   
   -   5        $ 	btnCancel��5      $
��Exit��6$   $
��Left=�63   $��50��6N   $��281,224,0,0q�6Z   $	��Top=�6o   $	��170��6�   $��16(�6�   �� 5   
   -   5         ��Name$ txtKey��5      $
��Left=�6"   $��40��6=   $��	102,7,0,0q�6I    �� TextWrapping$
 Wrap=�6\   $�� ��6p   $	��Top=�6x   $	��349��6�   $��16(�6�   �� 5   
   -   5        $ txtInputText��5      $
��Left=�6(   $��40��6C   $��
102,52,0,0q�6O   $
 Wrap=�6c   $�� ��6w   $	��Top=�6   $	��349��6�   $��16(�6�   �� 5   
   -   5         ��Name$ label��5      $	��Key��6   $
��Left=�6-   $��	56,10,0,0q�6H   $	��Top=�6[   $��20(�6s   �� 5   
   -   5        $ 
label_Copy��5      $��	PlainText��6$   $
��Left=�68   $��	10,52,0,0q�6S   $	��Top=�6f   $��20(�6~   �� 5   
   -   5        $ 	lblOutput��5      $�� ��6#   $
��Left=�6.   $��102,110,0,0q�6I   $	��Top=�6^   $	��109��6v   $	��349��6�   $��16(�6�   $��1q�6�   ���	#FFABADB3
�������6�   	� 5   
   -   5         	�Name$ 
radEncrypt��5      $��Encrypt��6*   $
��Left=�6<   $��
19,110,0,0q�6W   $	��Top=�6k   $��18(�6�   	 d� 	IsChecked$
	 TrueY�6�   	� 5   
   -	   5        $ 
radDecrypt��5      $��Decrypt��6*   $
��Left=�6<   $��
16,138,0,0q�6W   $	��Top=�6k   $��18(�6�   5      5      