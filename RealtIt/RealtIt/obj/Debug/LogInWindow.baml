   M S B A M L   `   `   `  ����B  >RealtIt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:RealtItRealtIt  5   	       RealtIt.LogInWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:RealtIt     5   	   -   5        $��	LogInForm��5        � Title$  LogInWindow��6	   $	��450��6.   $��370.788��6;    � AllowsTransparency .  � WindowStyle$
 None=�6e   
������  � WindowStartupLocation$ CenterScreen=�6�    J� Opacity$ 1Q�6  .��5	      � 
������ .+�5
   
   ��  �� CornerRadius$ 75��6   ���#060606$��3��68   ._�5      �  � ColumnDefinitions 5      �� 5      $	��51* �6'   �� 5      $
��237* �6'   �� 5      $	��32* �6'   �� 5      $	��51* �6'    � RowDefinitions 5      �� 5      $	��42* �6$   �� 5      $	��36* �6$   �� 5      $	��40* �6$   �� 5      $	��59* �6$   �� 5      $	��55* �6$   �� 5      $	��38* �6$   �� 5      $	��59* �6$   �� 5      $	��43* �6$   �� 5      $	��78* �6$   .+�5      ��  � Cursor$
 Hand��6   
�������$��36(�6:   $��SemiBold"�6H   $��0��6^   $��4��6k   $��2��6   ��5      �� 5       .R�5!      �� ���#121212	 �� Padding$	 
140 10 0 0q�6:   $ 	75 75 0 0��6O   ._�5"   "   �� $��Вход��63   5#      5$      5&      �� 5(      -   5        $��	CloseLink��5(      $!��/Resources/Images/Close.png��6)   $��3��6N   $��	13,0,0,10q�6^   6�   �� 5*      -   5        $��LogInButton��5*      $
 Hand��6,   
�������$��36(�6M   $��SemiBold"�6[   $��8��6q   $��4��6~   ��5+      �� 5,      .R�5-      �� ���#4E703E$	 
130 10 0 0q�6:   $ 	0 0 75 75��6O   ._�5.   "   �� $��
Войти��63   5/      50      52      �� 54      $��
Логин��6   
�������$��24(�6<   $��2��6J   $��1��6W   
 �� TextAlignment$
 Center=�6g   $��2��6~   �� 55      -   5        $��LogInBox��55      $��
Логин��6*   $��10q�67   $��5q�6D   ���#292727
�������$��20(�6v   $��6 0 6 0q�6�   $��3��6�   $��1��6�   ���#4E703E$��2��6�   �� 57      $��Пароль��6   
�������$��24(�6=   $��5��6K   $��1��6X   $
 Center=�6h   $��2��6   G� 58      -   5        $��PassBox��58       G� Password$ Пароль��6-   $��10q�6?   $��5q�6L   ���#292727
�������$��20(�6~   $��6 0 6 0q�6�   $��6��6�   $��1��6�   ���#4E703E$��2��6�   �� 59      -   5        $��
SignUpLink��59      $%��Resources/Images/multimedia.png��6*   $��2��6S   $��
14,0,38,16q�6c   $��2��6w   6�   5:      5;      5<      5=      