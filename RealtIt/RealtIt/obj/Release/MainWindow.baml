   M S B A M L   `   `   `  ���� B  >RealtIt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:RealtItRealtIt      RealtIt.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:RealtIt       � Title$  
MainWindow��$
��1080��$
��1920�� � AllowsTransparency .  � WindowStyle$
 None=� J� Effect -  'System.Windows.Media.Effects.BlurEffect  -   
BlurScreen��   Radius$ 0Q�.��� ���#121212 � ColumnDefinitions �� $
��474* ��� $
��140* ��� $
��140* ��� $
��140* ��� $
��140* ��� $
��140* ��� $
��172* ��� $
��140* ��� $
��308* ��� $
��138* � � RowDefinitions �� $	��28* ��� $��6* ��� $
��101* �.+��� $
��Fill=�$'��!/Resources/Images/RealtLogo_1.png��$��0��$��
15,15,10,0q�$��0���� $��2��$��0��.���� .+���    ScrollBarLineButtonStyle#��[  �� ���#707070$��1q�$
��Left=�$��2��$��	36,36,0,0q�$	��Top=�$	��400�� �� CornerRadius$ 1���� $��Тип сделки��
�������$
��Left=�$��	83,36,0,0q�$	��Top=�$��Segoe UI)�$��20(�$��SemiBold"�   RealtIt.Switch     RealtIt.Switch   MouseLeftButtonDown$ OfferTypeSwitchClick��	 � Cursor$
	 Hand��$��36��$	��200��$��
0,36,155,0q��� -   
 ��Name$
 OfferTypeLabel��$��Покупка��
�������$
��Left=�$��240,-38,0,0q�$	��Top=�$��Segoe UI)�$��20(�$��SemiBold"��� ���#707070$��1q�$
��Left=�$��2��$��	36,36,0,0q�$	��Top=�$	��400��$ 1���� $%��Тип недвижимости��
�������$
��Left=�$��	83,36,0,0q�$	��Top=�$��Segoe UI)�$��20(�$��SemiBold"�  $! AccomodationTypeSwitchClick��$
	 Hand��$��36��$	��200��$��
0,36,155,0q��� -   $
 AccomodationTypeLabel��$��Квартира��
�������$
��Left=�$��240,-38,0,0q�$	��Top=�$��Segoe UI)�$��20(�$��SemiBold"��� ���#707070$��1q�$
��Left=�$��2��$��	36,36,0,0q�$	��Top=�$	��400��$ 1���� $'��!Количество комнат��
�������$
��Left=�$��	83,36,0,0q�$	��Top=�$��Segoe UI)�$��20(�$��SemiBold"��� -   $��RoomsAmountSlider��$
	 Hand��$��	0 36 30 0q�$��24��$	��140�� � Minimum$ 0Q� � Maximum$ 10Q� �� SelectionEnd$ 4Q� �� IsSelectionRangeEnabled . ���� .R�� $��-68,0,-50,0q�.+��� $��5�����#332E2E$��0q�]�  ]�Name$ 
PART_Track��$��1�� ]� DecreaseRepeatButton ��   SliderButtonStyle#��[ $��Slider.DecreaseLarge�� ]� Thumb n� $��7��$��20�� ]� IncreaseRepeatButton �� #��[ $��Slider.IncreaseLarge���� -   $
 RoomsAmountLabel��$��0��
�������$
��Left=�$��380,-30,0,0q�$	��Top=�$��Segoe UI)�$��20(�$��SemiBold"��� ���#707070$��1q�$
��Left=�$��2��$��	36,36,0,0q�$	��Top=�$	��400��$ 1���� $$��Местонахождение��
�������$
��Left=�$��	83,36,0,0q�$	��Top=�$��Segoe UI)�$��20(�$��SemiBold"��� -    ��Name$ District��$
	 Hand��$��88 36 150 0q�$��30��$��20(�$��5 0 0 5q�����  �� 
TargetType" ��.���  �� Property � �� �� Value
 �������  � ��$ 16(� � 	Resources  �� Color��%}   (��       *SystemColors.WindowBrushKey+)(��      * SystemColors.HighlightBrushKey+)�� $ #121212���� $ White���� $��
Район��
�������$
��Left=�$��360,-30,0,0q�$	��Top=�$��Segoe UI)�$��20(�$��SemiBold"��� $��или��
�������$
��Left=�$��
180,36,0,0q�$	��Top=�$��Segoe UI)�$��20(�$��SemiBold"��� -   $ Street��$
	 Hand��$��88 36 150 0q�$��30��$��20(�$��5 0 0 5q����� " ��.���  � ��
 �������  � ��$ 16(� ��%}   (��       *SystemColors.WindowBrushKey+)(��      * SystemColors.HighlightBrushKey+)�� $ #121212���� $ White���� $��
Улица��
�������$
��Left=�$��360,-30,0,0q�$	��Top=�$��Segoe UI)�$��20(�$��SemiBold"��� ���#707070$��1q�$
��Left=�$��2��$��	36,36,0,0q�$	��Top=�$	��400��$ 1���� $��Стоимость��
�������$
��Left=�$��	83,36,0,0q�$	��Top=�$��Segoe UI)�$��20(�$��SemiBold"��� $
��От��
�������$
��Left=�$��	83,36,0,0q�$	��Top=�$��Segoe UI)�$��20(�$��SemiBold"��� -    ��Name$ FromCost��$��1��$��125 -30 275 0q�$��31�����#292727
�������$��20(�$��0q��� $
��До��
�������$
��Left=�$��205,-38,0,0q�$	��Top=�$��Segoe UI)�$��20(�$��SemiBold"��� -	   $ ToCost��$
��1000��$��255 -30 145 0q�$��31�����#292727
�������$��20(�$��0q��� $	��BYN��
�������$
��Left=�$��335,-38,0,0q�$	��Top=�$��Segoe UI)�$��20(�$��SemiBold"��� ���#707070$��0q�$
��Left=�$��2��$��	36,36,0,0q�$	��Top=�$	��400��$ 1���� ���#707070$��0q�$
��Left=�$��2��$��	36,36,0,0q�$	��Top=�$	��400��$ 1���� ���#707070$��0q�$
��Left=�$��2��$��	36,36,0,0q�$	��Top=�$	��400��$ 1���� ���#707070$��1q�$ 1��$��22,31,22,15q�$��1��   RealtIt.Tongue  -
     Name$ TongueMoneyUp��   RealtIt.Tongue   
MouseEnter$ TongueMouseEnter��   
MouseLeave$ TongueMouseLeave��   	MouseDown$ TongueMouseDown��$
	 Hand��$��0��$��2��$
��Auto��$��
0,-100,0,0q�$��10q�  -   $ TongueMoneyDown��$ TongueMouseEnter��$ TongueMouseLeave��$ TongueMouseDown��$
	 Hand��$��0��$��3��$��
0,-100,0,0q�$
��Auto��$��10q�  -   $ TongueRoomUp��$ TongueMouseEnter��$ TongueMouseLeave��$ TongueMouseDown��$
	 Hand��$��0��$��4��$��
0,-100,0,0q�$
��Auto��$��10q�  -   $ TongueRoomDown��$ TongueMouseEnter��$ TongueMouseLeave��$ TongueMouseDown��$
	 Hand��$��0��$��5��$��
0,-100,0,0q�$
��Auto��$��10q�  -   $ 	TongueAdd��$ TongueMouseEnter��$ TongueMouseLeave��$ AddMouseDown��$
	 Hand��$��0��$��7��$��
0,-100,0,0q�$
��Auto��$��10q��� -    ��Name$ LogInButtob��$
	 Hand��$��8��$��40 20 20 130q�
�������$��36(�$��SemiBold"����� .R��� ���#4E703E �� Padding$ 	85 10 0 0q�._��� $��Вход���� -   $
	 Hand��$
��Left=�$!��/Resources/Images/Close.png��$��9��$��81��$��41,15,0,128q��� $
��Left=�$��40,9,0,0q�$
��Wrap=�$'��!Отсортированно по��$	��Top=�$��35��$	��216��$��22(�$��SemiBold"�
�������$��2��$��1��$��1���� -     ��Name$  SortedByWhat��$
��Left=�$��	117,9,0,0q�$
��Wrap=�$��комнатам��$	��Top=�$��35��$	��164��$��22(�$��SemiBold"�
����������#4E703E! �� TextAlignment$! Center=�$��3��$��2��$��1���� $
��Left=�$��17,9,0,0q�$
��Wrap=�$
��по��$	��Top=�$��35��$��30��$��22(�$��SemiBold"�
�������$��4��$��1���� -   $  	SortedHow��$
��Left=�$��57,9,0,0q�$
��Wrap=�$��возрастанию��$	��Top=�$��35��$	��164��$��22(�$��SemiBold"�
����������#4E703E$! Center=�$��2��$��4��$��1��� $
��Left=�$	��754��$��	19,15,0,0q�$	��Top=�$
��1411��$��2��$��1��$��9��.+��� 
������ $��0,0,-10,-37q�.���� .+��� .+��� -   " ��Name$" AccomodationList������ *Accomodation+���� .R��� $��10,10,10,10q�$	��640��$	��544��$��1q�
���   �._��� $��0,0,0,0q�.+��� $	��590��$	��330��$��5, 10q�$��1q�
���   � 3  -System.Windows.Media.Effects.DropShadowEffect  #   ShadowDepth$# 1Q����� $ �� ImageSource$ �� *imageSource+�� 
�������% �� Padding$% 0 5 0 5q�$��
24,1,412,0q�$��20(�$��Segoe UI)�$��SemiBold"�$! Center=����#4E703E$��39������ *
District+�� 
�������$��235,-35,329,0q�$��район,��$��20(�$��Segoe UI)�$��SemiBold"��� 
�������$% 0 5 0 5q�$��305,-39,116,0q�$��20(�$��Segoe UI)�$��SemiBold"�$! Center=����#4E703E$��39������ *Street+�� 
�������$��532,-35,0,0q�$��
улица��$��20(�$��Segoe UI)�$��SemiBold"��� 
�������$% 0 5 0 5q�$��
0,15,544,0q�$��Дом��$��20(�$��Segoe UI)�$��SemiBold"�$! Center=�$��39���� $��80,-39,489,0q�$��39��$��2q����#4E703E._��� 
�������$% 0 3 0 5q�$��20(�$��Segoe UI)�$��SemiBold"�$! Center=����� *HouseNumber+�� 
�������$% 0 5 0 5q�$��175,-40,325,0q�$��Комнаты��$��20(�$��Segoe UI)�$��SemiBold"�$! Center=�$��39���� $��300,-40,275,0q�$��39��$��2q����#4E703E._��� 
�������$% 0 3 0 5q�$��20(�$��Segoe UI)�$��SemiBold"�$! Center=����� *RoomsAmount+�� 
�������$% 0 5 0 5q�$��325,-40,100,0q�$��Цена��$��20(�$��Segoe UI)�$��SemiBold"�$! Center=�$��39���� $��470,-40,75,0q�$��39��$��2q����#4E703E._��� 
�������$% 0 3 0 5q�$��20(�$��Segoe UI)�$��SemiBold"�$! Center=����� *Cost+�� $��133,16,412,0q�$��39��$��2q����#4E703E._��� 
�������$% 0 3 0 5q�$��20(�$��Segoe UI)�$��SemiBold"�$! Center=����� *Area+�� 
�������$% 0 5 0 5q�$��0,-40,499,0q�$��Площадь��$��20(�$��Segoe UI)�$��SemiBold"�$! Center=�$��39���� $
	 Hand��$	��175��$��50��$��0 0 0 0q�$��20(�$��Подробнее��
�������$��35 9 0 0q�$��SemiBold"�$��Segoe UI)����#6C1980$��0q�$��Right=�$��Bottom=�  LeftTopCornerButtonTemplate#��[ ���� .R�� 