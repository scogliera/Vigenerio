   M S B A M L   `   `   `  ���� D  @Vigenerio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Vigenerio	Vigenerio      Vigenerio.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:Vigenerio     -     � Title$  	Vigenerio��$	��475��$	��800��$	��450��$	��800�����#00001e.���� -   $��Border��$��2q�|�. ����  �� 
StartPoint$
 .6,0&� �� EndPoint$
 .5,1&�.���  � Color$ #031163�� � Offset$ 0Q�� $ #1fbfb8��$ 1Q�._��  � RowDefinitions �� $	��.4* ��� $	��.4* ��� $	��.4* ��� $��* � � ColumnDefinitions �� $��* ��� $��3* �.+�(� $��0��$��0��$��Center=�$��Right=�$��15q�.���� ���#fff$��Text:��$��25(�$
��Bold"�$��5q�$��Right=�(� $��1��$��0��$��Center=�$��Right=�$��15q�.���� ���#fff$��	Password:��$��25(�$
��Bold"�$��5q�$��Right=�(� $��2��$��0��$��Center=�$��Right=�$��15q�.����  �� Padding$ 5 0 5 0q�$��1�����#fff$��Enc/Dec:��$��25(�$
��Bold"�$��5q�$��Right=�(� $��0��$��1��$��Center=�$
��Left=�$��10q�.���� -   $��TextTextBlock�����#fff$��Enter some text!��$��15(�$
��Bold"�$��5q�(� $��1��$��1��$��Center=�$
��Left=�$��10q�.���� -   $��PasswordTextBlock�����#fff$��Enter a password!��$��25(�$
��Bold"�$��5q�� $��2��$��1�� �� $��5* ��� $��* �.+�(� $��0��$��Center=�$
��Left=�$��0q�.���� -   $��ResultTextBlock��
������ ���#fff$��
 NO INPUT ��$��25(�$
��Bold"�$��5q��� -   $��20 15q�$��1�����#000���#fff$��15(�$�� Copy ��(� $��4��$��2��$��Center=�$��Center=�$��10q�.���� $��Center=�$��Center=�$��0 15 0 0q�.+��  �� $��* ��� $��* �.+�	� -   $��75 0 0 0q�$��0�����#fff$��15(� d� 	IsChecked$
 TrueY�.��	Encrypt	� -   $��75 0 0 0q�$��1�����#fff$��15(�.��	Decrypt�� -	   $��TextTextBox�����#171717���#777777$	��5 0q�$,��&Enter a sentence to encrypt/decrypt...��$��25(�$	��500��$��	0 20 0 10q�$��1q����#373737	 �� AcceptsReturn	 . $
 �� HorizontalScrollBarVisibility$
 Disabled=��� -
   $��PasswordTextBox�����#171717���#777777$	��5 0q�$��Password��$��25(�$	��450��$��	0 10 0 10q�$��1q����#373737