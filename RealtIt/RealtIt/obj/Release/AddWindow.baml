   M S B A M L   `   `   `  ���� B  >RealtIt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:RealtItRealtIt      RealtIt.AddWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:RealtIt       � Title$  	AddWindow��$
��1080��$
��1920�� � AllowsTransparency .  � WindowStyle$
 None=����#121212 � WindowState$ 	Maximized=�.��� .+�� $
��Left=�$
��1049��$	��Top=�$	��486��.+��� $
��Fill=�$'��!/Resources/Images/RealtLogo_1.png��$
��Left=�$	��202��$��	48,34,0,0q�$	��Top=�$	��392���� .���� $
��1072��.+���    ScrollBarLineButtonStyle#��[  �� ���#707070$��1q�$
��Left=�$��2��$��
36,250,0,0q�$	��Top=�$	��400�� �� CornerRadius$ 1���� $��Тип сделки��
�������$
��Left=�$��	83,36,0,0q�$	��Top=�$��Segoe UI)�$��20(�$��SemiBold"�   RealtIt.Switch     RealtIt.Switch   MouseLeftButtonDown$ OfferTypeSwitchClick�� � Cursor$
 Hand��$��36��$	��200��$��
0,36,155,0q��� -    ��Name$ OfferTypeLabel��$��Покупка��
�������$
��Left=�$��240,-38,0,0q�$	��Top=�$��Segoe UI)�$��20(�$��SemiBold"��� ���#707070$��1q�$
��Left=�$��2��$��	36,36,0,0q�$	��Top=�$	��400��$ 1���� $%��Тип недвижимости��
�������$
��Left=�$��	83,36,0,0q�$	��Top=�$��Segoe UI)�$��20(�$��SemiBold"�  $! AccomodationTypeSwitchClick��$
 Hand��$��36��$	��200��$��
0,36,155,0q��� -   $ AccomodationTypeLabel��$��Квартира��
�������$
��Left=�$��240,-38,0,0q�$	��Top=�$��Segoe UI)�$��20(�$��SemiBold"��� ���#707070$��1q�$
��Left=�$��2��$��	36,36,0,0q�$	��Top=�$	��400��$ 1���� $'��!Количество комнат��
�������$
��Left=�$��	83,36,0,0q�$	��Top=�$��Segoe UI)�$��20(�$��SemiBold"��� -   $��RoomsAmountSlider��$
 Hand��$��	0 36 30 0q�$��24��$	��140�� � Minimum$ 0Q�	 � Maximum$	 10Q�
 �� SelectionEnd$
 4Q� �� IsSelectionRangeEnabled . ���� .R�� $��-68,0,-50,0q�.+��� $��5�����#332E2E$��0q�]�  ]�Name$ 
PART_Track��$��1�� ]� DecreaseRepeatButton ��   SliderButtonStyle#��[ $��Slider.DecreaseLarge�� ]� Thumb n� $��7��$��20�� ]� IncreaseRepeatButton �� #��[ $��Slider.IncreaseLarge���� -   $ RoomsAmountLabel��$��0��
�������$
��Left=�$��380,-30,0,0q�$	��Top=�$��Segoe UI)�$��20(�$��SemiBold"��� ���#707070$��1q�$
��Left=�$��2��$��	36,36,0,0q�$	��Top=�$	��400��$ 1���� $S��MПеренесите в папку фотографии
вашего дома��
�������$
��Left=�$��	83,36,0,0q�$	��Top=�$��Segoe UI)�$��20(�$��SemiBold"�$��91���� $
��Left=�$��72��$��	80,10,0,0q�$	��Top=�$��72��$"��/Resources/Images/folder.png���� ���#707070$��0q�$
��Left=�$��2��$��	36,36,0,0q�$	��Top=�$	��400��$ 1���� ���#707070$��0q�$
��Left=�$��2��$��	36,36,0,0q�$	��Top=�$	��400��$ 1���� ���#707070$��0q�$
��Left=�$��2��$��	36,36,0,0q�$	��Top=�$	��400��$ 1��� $
��Left=�$
��1080��$��	491,0,0,0q�$	��Top=�$	��350��.+��� $��
Район��
�������$
��Left=�$��	10,18,0,0q�$	��Top=�$��Segoe UI)�$��20(�$��SemiBold"��� $��
Идиот��$��10q�$��10,55,90,965q�$��50��$	��250�����#292727
�������$��20(�$��0q��� $��
Улица��
�������$
��Left=�$��
90,129,0,0q�$	��Top=�$��Segoe UI)�$��20(�$��SemiBold"��� $��
Идиот��$��10q�$��90,166,10,854q�$��50��$	��250�����#292727
�������$��20(�$��0q��� $��Дом��
�������$
��Left=�$��
10,241,0,0q�$	��Top=�$��Segoe UI)�$��20(�$��SemiBold"��� $��
Идиот��$��10q�$��10,277,90,741q�$��50��$	��250�����#292727
�������$��20(�$��0q��� $��Площадь��
�������$
��Left=�$��
90,356,0,0q�$	��Top=�$��Segoe UI)�$��20(�$��SemiBold"��� $��
Идиот��$��10q�$��90,388,10,621q�$��50��$	��250�����#292727
�������$��20(�$��0q��� $��фИО��
�������$
��Left=�$��
10,469,0,0q�$	��Top=�$��Segoe UI)�$��20(�$��SemiBold"��� $��
Идиот��$��10q�$��10,499,90,507q�$��50��$	��250�����#292727
�������$��20(�$��0q��� $��Цена��
�������$
��Left=�$��
90,588,0,0q�$	��Top=�$��Segoe UI)�$��20(�$��SemiBold"��� $��
Идиот��$��10q�$��90,610,10,381q�$��50��$	��250�����#292727
�������$��20(�$��0q��� $��Телефон��
�������$
��Left=�$��
10,705,0,0q�$	��Top=�$��Segoe UI)�$��20(�$��SemiBold"��� $��
Идиот��$��10q�$��10,722,90,258q�$��50��$	��250�����#292727
�������$��20(�$��0q�� $��	0,860,0,0q����#292727 J� Opacity$	 0.1Q�� $
��Left=�$
��1080��$��	846,0,0,0q�$	��Top=�$
��1074��.+��� $
��Left=�$��72��$��
992,10,0,0q�$	��Top=�$��72��$!��/Resources/Images/Close.png���� $��5q�$��116,128,152,448q�$ 25����L�  j� Viewport$ 	0,0,52,52� j� ViewportUnits$ Absolute=� j� TileMode$
 Tile=� L� Drawing I� .���  � Brush �#4E703E � Geometry � .����  �� Rect$ 	0,0,50,50��� $ 50,50,50,50�._��� $��Drop Image Here!��$��239,218,242,215q�$��40(�$��ExtraCondensed&�
��������� $��149,161,182,481q�$ 25��._��� �� $��Выбрать��$
��Left=�$��794,585,0,0q�$	��Top=�$	��118�� # RightBottomCornerButtonTemplate#��[ $��37�����#585858$��	35 10 0 0q��� $��116,738,152,44q����#292727���#707070$��1q�$ 	0 100 0 0��._��� 
������ $��10 20 20 20q�$��24(�
������� �� AcceptsReturn . $��0,0,-1,0q�$��0q� �� TextWrapping$
 Wrap=��� $��Описание��
�������$
��Left=�$��116,701,0,0q�$	��Top=�$��Segoe UI)�$��20(�$��SemiBold"��� $��Отправить��
�������$��16(�$��SemiBold"�$��	20 10 0 0q�$
��Left=�$��940,994,0,0q�$	��Top=�$	��122��$��42��  RightRoundButtonTemplate#��[ 