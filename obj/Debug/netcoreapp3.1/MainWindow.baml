   M S B A M L   `   `   `  ����B  >WpfApp7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp7WpfApp7  5   	       WpfApp7.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp7     5   	     � Title$  Kavlak.com.tr��5   	   $
��1636��6   $
��1427��6-    � WindowStartupLocation$ Manual=�6:    � SizeToContent$ Manual=�6Y    � WindowState$ Normal=�6p    � 
ResizeMode$ CanMinimize=�6�   $��Center=�6�   .��5	      � $
��3981��6   $��3,0,3,0q�6    � ColumnDefinitions 5
   
   �� 5      $
��237* �6   �� 5      $
��669* �6   �� 5      $
��335* �6   �� 5      $
��181* �6    � RowDefinitions 5   
   �� 5      $	��59* �6   �� 5      $
��538* �6   .+�5   
   �� $��2��6   $
��1613��6(   $	��Top=�66   $��0,0,9,0q�6N   $��4��6_   .��5      � $
��3878��6    J� RenderTransformOrigin$ 0.504,0.309&�6!   .+�5      � $��
0,0,0,1454q�6    K� ZIndex$ 1��6+    5      �� 5      $
��434* �6+   �� 5      $��* �6+   �� 5      $��0* �6+   �� 5      $
��961* �6+   .+�5       �� 
���"�"�$
��Left=�67   $��
824,32,0,0q�6R   $	��Top=�6f   $��57��6~   $��82��6�   ���	#FF14801E$	��ARA��6�   
�������$��22(�6�   $��2��6�   $��2��6�   �� 5!      -   5        	 ��Name$	 AnaResim��5!      $��images/R1.jpg��6.   $��95,315,110,1759q�6E   $ 15��6^   $��4��6p   �� 5"      -   5        
 ��Name$
 Geribtn��5"      
���"�"�$
��Left=�6H   $��
43,463,0,0q�6c   $	��Top=�6w   $��95��6�   $��54��6�   $��<��6�   ���	#FF535353$��36(�6�   $
��Bold"�6�   $ 
0.511,0.54&�6�   ��5#      �� 5$       �� EndPoint$ 0.5,1&�62    �� 
StartPoint$ 0.5,0&�6C   .��5%   "   �  � Color$ Black��6/   � 5&   "   $ 	#FFEEE9E9��6/    � Offset$ 0.959Q�6A   � 5'   "   $ 	#FF373636��6/   $ 0.089Q�6A   � 5(   "   $ 	#FF373636��6/   $ 0Q�6A   5)      5+      �� 5-      $��images/headback.png��6   $
��Left=�6:   $��90��6U   $	��Top=�6a   $	��543��6y   $ 2��6�   $��4��6�   �� 5.      $��images/h.png��6   $
��Left=�62   $��64��6M   $��
10,122,0,0q�6Y   $	��Top=�6m   $	��315��6�   $ 3��6�   �� 5/      -   5         ��Name$
 chan��5/      $��Ürünlerde Ara��6,    �� TextWrapping$
 Wrap=�6A   $��480,29,147,2338q�6U   ���	#FFEEEEEE���	#FF878585$��22(�6�   ���	#FF999999$��1,1,1,1q�6�   $ 1,0.5&�6�   $��2��64  $��2��6D  �� 51      $
��Left=�6    $��	24,20,0,0q�6;   $��150 TL ve Üzeri��6N   $
��Wrap=�6e   $	��Top=�6y   $��33��6�   $	��175��6�   
�������$ 5��6�   $��24(�6�   �� 52      $
��Left=�6    $��
200,10,0,0q�6;   $��KARGO BEDAVA!��6O   $
��Wrap=�6d   $	��Top=�6x   $��53��6�   $	��280��6�   
�������$ 5��6�   $��37(�6�   $��4��6�   �� 53      -   5        $
 ileribtn��53      
���"�"�$
��Left=�6I   $��850,473,0,0q�6d   $	��Top=�6y   $��89��6�   $��46��6�   $��>��6�   ���	#FF514F4F$��36(�6�   $
��Bold"�6�   $ 
0.587,0.59&�6�   $��2��6%  $��2��65  ��54      �� 55      $ 0.5,1&�62   $ 0.5,0&�6C   .��56   "   � $ Black��6/   � 57   "   $ 	#FFEEE9E9��6/   $ 0.959Q�6A   � 58   "   $ 	#FF373636��6/   $ 0.089Q�6A   � 59   "   $ 	#FF373636��6/   $ 0Q�6A   5:      5<      �� 5=      -   5        $��500,210,397,2175q�5=      $ 
0.57,0.551&�66   $��images\add-user.png��6Y   $ 11��6v   $��2��6�   $��2��6�   6�   �� 5>      -   5         ��Name$ uyeollbl��5>      $��Üye Ol��6.   $
��Left=�6?   $��556,212,0,0q�6Z   $	��Top=�6o   $��20(�6�   $��2��6�   $��2��6�   6�   �� 5?      -   5        $��632,213,263,2172q�5?      $ 
0.57,0.551&�66   $��images\user.png��6Y   $ 12��6r   $��2��6�   $��2��6�   6�   �� 5@      -   5        $ girisyaplbl��5@      $��
Giriş Yap��61   $
��Left=�6E   $��686,216,0,0q�6`   $	��Top=�6u   $��20(�6�   $��2��6�   $��2��6�   6�   �� 5A      -	   5        $	 sepet��5A      $��774,216,115,2168q�6+   $ 
0.57,0.551&�6E   $��images\buy.png��6h   $ 13��6�   $��2��6�   $��2��6�   6�   �� 5B      -
   5        $��Sepetim��5B      $
��Left=�6.   $��834,216,0,0q�6I   $	��Top=�6^   $��20(�6v   $��2��6�   $��2��6�   6�   �� 5C      $��images/kavlaklogo.png��6   $��429,194,515,2063q�6;   $ 16��6U   $��4��6g   o� 5D      $��112,736,121,0q�6   $��30(�6H   $��Cambria Math)�6V   $	��Top=�6p   $��56��6�   $��4��6�   ��62   Z� .@�5E      m� $��
Zeytin ↓��6$   $	��142��66   .@�5F      m� -   5         m�Name$ siyahzeytin��5F   '   $��Siyah Zeytin��6<   
�������
���"�"�$��18(�6�   $
��Left=�6�   $	��194��6�   6�   m� 5H      $��Yeşil Zeytin��6'   
�������
���"�"�$��18(�6k   $
��Left=�6y   $	��194��6�   5J      m� 5K      $��Zeytinyağı��6#   $	��171��67   m� 5L      $��Şaküteri ↓��6#   $	��160��67   .@�5M      m� $��Peynir��6'   
�������
���"�"�$��18(�6d   $
��Left=�6r   $	��140��6�   m� 5O      $��Reçel��6'   
�������
���"�"�$��18(�6c   $
��Left=�6q   $	��140��6�   m� 5Q      $��İçecek��6'   
�������
���"�"�$��18(�6d   $
��Left=�6r   $	��140��6�   m� 5S      $��Diğer��6'   
�������
���"�"�$��18(�6d   $
��Left=�6r   $	��140��6�   5U      m� 5V      $��	Turşular��6#   $	��153��65   m� 5W      $��Kozmetik��6#   $	��171��65   m� 5X      $��Ev Yapımı��6#   $	��152��66   m� 5Y      $��
Şekerleme��6#   $ 0.556,0.631&�66   $��38��6Z   $	��185��6f   5]      5_      � 5`      $��0,866,0,-2259q�6   .+�5b      �� -   5        $ kampanyalar��5b      $��Center=�61   $
��Left=�6U   $��
284,10,0,0q�6p   $	��Top=�6�   $��48��6�   $	��172��6�   $��23(�6�   $ 0.157,0.537&�6�   
���   �$��Kampanyalar��6X  $y�Visible=�6n  ��6�   Z� 5d      �� 5e      -   5        $ cokSatanlar��5e      $��Çok Satanlar��61   $��Center=�6H   $
��Left=�6l   $��
492,10,0,0q�6�   $	��Top=�6�   $��49��6�   $	��160��6�   
�������
�������$��23(�6�   5g      �� 5h      -   5        $ firsat��5h      $��Fırsat Ürünleri��6,   $��Center=�6F   $
��Left=�6j   $��
689,11,0,0q�6�   $	��Top=�6�   $��49��6�   $	��173��6�   
�������
�������$��23(�6�   6  �� 5j      -   5        $
 yeni��5j      $��Yeni Ürünler��6*   $��Center=�6A   $
��Left=�6e   $��
903,12,0,0q�6�   $	��Top=�6�   $��48��6�   $	��168��6�   
�������
�������$��23(�6�   6  �� 5k      -   5         ��Name$	 ilk��5k      $�� ��6,   $��
33,108,0,0q�66   $	��640��6J   $	��Top=�6W   $
��Left=�6o   $	��300��6�   .��5l      �� -   5        $	 ilkfoto��5l       $��images/1.jpg��61   $	��277��6G   $	��Top=�6T   $��0,0,-2,0q�6l   5m      �� 5n      -   5        $
��Left=�5n       $��
78,430,0,0q�6;   $<��6Kavlak Naturel Sızma 2li 5 LT Özel Fiyatlı Kampanya��6O   $
��Wrap=�6�   $	��Top=�6�   $	��144��6�   $	��210��6�   $��24(�6�   $
��Bold"�6�   6�   �� 5o      $
��Left=�6    $��
78,548,0,0q�6;   $_��YYağ oranı yüksek Gemlik zeytinlerinden, son sistem kontinü zeytinyağı fabrikasın..��6O   $
��Wrap=�6�   $	��Top=�6�   $��91��6�   $	��191��6�   $��Normal"�6�   $��15(�6  �� 5p      $
��Left=�6    $��
58,664,0,0q�6;   $��  %28��6O   $
��Wrap=�6\   $	��Top=�6p   $��84��6�   $��Normal"�6�   $��25(�6�   ���#D71B1A � Cursor$ No��6�   $��37��6�   $��Comic Sans MS)�6�   
�������6�   �� 5q      $
��Left=�6    $��174,665,0,0q�6;   $��
 289,90 TL��6P   $
��Wrap=�6b   $	��Top=�6v   $��36��6�   $	��138��6�   $��Normal"�6�   $��25(�6�   ���#EDEDED$��Comic Sans MS)�6�   �� 5r      -   5        $	 iki��5r      $�� ��6,   $��366,108,0,0q�66   $	��640��6K   $	��Top=�6X   $
��Left=�6p   $	��300��6�   .��5s      �� $��images/2.jpg��6    $	��277��66   $	��Top=�6C   $��0,0,-2,0q�6[   5u      �� 5v      -   5        $
��Left=�5v       $��411,430,0,0q�6;   $'��!Kavlak Bahara Merhaba Kampanyası��6P   $
��Wrap=�6x   $	��Top=�6�   $	��144��6�   $	��210��6�   $��24(�6�   $
��Bold"�6�   6�   �� 5w      $
��Left=�6    $��411,548,0,0q�6;   $_��YKavlak Zeytinden bahara merhaba! 5 Lt Kavlak Taş Baskı Soğuk Sıkım Zeytinyağı Al..��6P   $
��Wrap=�6�   $	��Top=�6�   $��91��6�   $	��191��6�   $��Normal"�6�   $��15(�6  �� 5x      $
��Left=�6    $��406,665,0,0q�6;   $��  %21��6P   $
��Wrap=�6]   $	��Top=�6q   $��84��6�   $��Normal"�6�   $��25(�6�   ���#D71B1A$ No��6�   $��37��6�   $��Comic Sans MS)�6�   
�������6�   �� 5y      $
��Left=�6    $��509,665,0,0q�6;   $��
 229,90 TL��6P   $
��Wrap=�6b   $	��Top=�6v   $��36��6�   $	��138��6�   $��Normal"�6�   $��25(�6�   ���#EDEDED$��Comic Sans MS)�6�   �� 5z      -   5        $ uc��5z      $�� ��6+   $��721,108,0,0q�65   $	��640��6J   $	��Top=�6W   $
��Left=�6o   $	��300��6�   .��5{      �� $��images/3.jpg��6    $	��277��66   $	��Top=�6C   $��0,0,-2,0q�6[   5}      �� 5~      -   5        $
 dort��5~      $�� ��6-   $��
0,108,29,0q�67   $	��640��6K   $	��Top=�6X   $��Right=�6p   $	��300��6�   .��5      �� $��images/4.jpg��6    $	��253��66   $	��Top=�6C   $��
42,0,-23,0q�6[   5�      �� 5�      -   5        $
��Left=�5�       $��766,430,0,0q�6;   $;��5Kavlak Zeytinyağlı El Kremi 150 ml 2 Alana 1 Bedava��6P   $
��Wrap=�6�   $	��Top=�6�   $	��144��6�   $	��210��6�   $��24(�6�   $
��Bold"�6�   6�   �� 5�      -   5        $
��Left=�5�       $��1099,430,0,0q�6;   $2��,Kavlak Delice Zeytinyağı 500 ml Cam Şişe��6Q   $
��Wrap=�6�   $	��Top=�6�   $	��144��6�   $	��210��6�   $��24(�6�   $
��Bold"�6�   6�   �� 5�      $
��Left=�6    $��766,548,0,0q�6;   $^��XKavlak Zeytinyağlı el kremi ile elleriniz yumuşacık olacak ve narinliğini gün bo..��6P   $
��Wrap=�6�   $	��Top=�6�   $��91��6�   $	��191��6�   $��Normal"�6�   $��15(�6  �� 5�      $
��Left=�6    $��1099,563,0,0q�6;   $]��WDoğada kendiliğinden yetişen tamamen doğan deli zeytinlerin toplanmasıyla ve ilk..��6Q   $
��Wrap=�6�   $	��Top=�6�   $��91��6�   $	��191��6�   $��Normal"�6�   $��15(�6  �� 5�      $
��Left=�6    $��766,665,0,0q�6;   $��  %33��6P   $
��Wrap=�6]   $	��Top=�6q   $��84��6�   $��Normal"�6�   $��25(�6�   ���#D71B1A$ No��6�   $��37��6�   $��Comic Sans MS)�6�   
�������6�   �� 5�      $
��Left=�6    $��871,665,0,0q�6;   $��
  49,80 TL��6P   $
��Wrap=�6b   $	��Top=�6v   $��36��6�   $	��138��6�   $��Normal"�6�   $��25(�6�   ���#EDEDED$��Comic Sans MS)�6�   �� 5�      $
��Left=�6    $��1135,674,0,0q�6;   $��
  99,90 TL��6Q   $
��Wrap=�6c   $	��Top=�6w   $��36��6�   $	��138��6�   $��Normal"�6�   $��25(�6�   ���#EDEDED$��Comic Sans MS)�6�   �� 5�      -   5        $	 bes��5�      $�� ��6,   $��
33,806,0,0q�66   $	��640��6J   $	��Top=�6W   $
��Left=�6o   $	��300��6�   .��5�      �� $��images/5.jpg��6    $	��277��66   $	��Top=�6C   $��-6,0,4,0q�6[   5�      �� 5�      -   5        $
��Left=�5�       $��66,1107,0,0q�6;   $;��5Kavlak Taş Baskı Gemlik Siyah Zeytin 3 lü Kampanya��6P   $
��Wrap=�6�   $	��Top=�6�   $	��144��6�   $	��234��6�   $��24(�6�   $
��Bold"�6�   6�   �� 5�      $
��Left=�6    $��78,1251,0,0q�6;   $\��VGemlikin en lezzetli sofralık siyah zeytini Taş Baskı farkı ile ve en uygun kamp..��6P   $
��Wrap=�6�   $	��Top=�6�   $��91��6�   $	��191��6�   $��Normal"�6�   $��15(�6  �� 5�      $
��Left=�6    $��58,1360,0,0q�6;   $��  %24��6P   $
��Wrap=�6]   $	��Top=�6q   $��84��6�   $��Normal"�6�   $��25(�6�   ���#D71B1A$ No��6�   $��37��6�   $��Comic Sans MS)�6�   �� 5�      $
��Left=�6    $��174,1361,0,0q�6;   $��
 249,90 TL��6Q   $
��Wrap=�6c   $	��Top=�6w   $��36��6�   $	��138��6�   $��Normal"�6�   $��25(�6�   ���#EDEDED$��Comic Sans MS)�6�   �� 5�      -   5        $
 alti��5�      $�� ��6-   $��366,806,0,0q�67   $	��640��6L   $	��Top=�6Y   $
��Left=�6q   $	��300��6�   .��5�      �� $��images/6.jpg��6    $	��277��66   $	��Top=�6C   $��0,0,-2,0q�6[   5�      �� 5�      -   5        $
��Left=�5�       $��411,1105,0,0q�6;   $2��,Kavlak Zeytin Ezmesi 280 gr 1 Alana 1 Bedava��6Q   $
��Wrap=�6�   $	��Top=�6�   $	��144��6�   $	��210��6�   $��24(�6�   $
��Bold"�6�   6�   �� 5�      $
��Left=�6    $��411,1231,0,0q�6;   $]��WKahvaltıların vazgeçilmez lezzetleri arasında yer alan zeytin ezmesi artık Kavla..��6Q   $
��Wrap=�6�   $	��Top=�6�   $��91��6�   $	��191��6�   $��Normal"�6�   $��15(�6  �� 5�      $
��Left=�6    $��506,1360,0,0q�6;   $��
  24,90 TL��6Q   $
��Wrap=�6c   $	��Top=�6w   $��36��6�   $	��138��6�   $��Normal"�6�   $��25(�6�   ���#EDEDED$��Comic Sans MS)�6�   �� 5�      $
��Left=�6    $��406,1361,0,0q�6;   $��  %50��6Q   $
��Wrap=�6^   $	��Top=�6r   $��84��6�   $��Normal"�6�   $��25(�6�   ���#D71B1A$ No��6�   $��37��6�   $��Comic Sans MS)�6�   �� 5�      -   5        $
 yedi��5�      $�� ��6-   $��721,806,0,0q�67   $	��640��6L   $	��Top=�6Y   $
��Left=�6q   $	��300��6�   .��5�      �� $��images/7.jpg��6    $	��277��66   $	��Top=�6C   $��0,0,-2,0q�6[   5�      �� 5�      -   5        $ sekiz��5�      $�� ��6.   $��1054,806,0,0q�68   $	��640��6N   $	��Top=�6[   $
��Left=�6s   $	��300��6�   .��5�      �� $��images/8.jpg��6    $	��277��66   $	��Top=�6C   $��0,0,-2,0q�6[   5�      �� 5�      -   5        $
��Left=�5�       $��766,1105,0,0q�6;   $6��0Kavlak Premium 3lü 5 LT Özel Fiyatlı Kampanya��6Q   $
��Wrap=�6�   $	��Top=�6�   $	��144��6�   $	��210��6�   $��24(�6�   $
��Bold"�6�   6�   �� 5�      -    5        $
��Left=�5�       $��1099,1105,0,0q�6;   $B��<Kavlak Taş Baskı Zeytinyağı 3lü Özel Fiyatlı Kampanya��6R   $
��Wrap=�6�   $	��Top=�6�   $	��144��6�   $	��210��6�   $��24(�6�   $
��Bold"�6�   6�   �� 5�      $
��Left=�6    $��766,1231,0,0q�6;   $_��YPremium Soğuk Sıkım Zeytinyağında siz istediniz biz gerçekleştirdik. 2 adet 5 LT..��6Q   $
��Wrap=�6�   $	��Top=�6�   $��91��6�   $	��191��6�   $��Normal"�6�   $��15(�6  �� 5�      $
��Left=�6    $��1099,1231,0,0q�6;   $a��[Taş değirmenlerde ezilerek soğuk sıkım yöntemi ile elde edilen gerçek Taş Baskı ..��6R   $
��Wrap=�6�   $	��Top=�6�   $��91��6�   $	��191��6�   $��Normal"�6�   $��15(�6  �� 5�      $
��Left=�6    $��766,1359,0,0q�6;   $��  %26��6Q   $
��Wrap=�6^   $	��Top=�6r   $��84��6�   $��Normal"�6�   $��25(�6�   ���#D71B1A$ No��6�   $��37��6�   $��Comic Sans MS)�6�   �� 5�      $
��Left=�6    $��1086,1359,0,0q�6;   $��  %33��6R   $
��Wrap=�6_   $	��Top=�6s   $��84��6�   $��Normal"�6�   $��25(�6�   ���#D71B1A$ No��6�   $��37��6�   $��Comic Sans MS)�6�   �� 5�      $
��Left=�6    $��871,1360,0,0q�6;   $��
 459,90 TL��6Q   $
��Wrap=�6c   $	��Top=�6w   $��36��6�   $	��138��6�   $��Normal"�6�   $��25(�6�   ���#EDEDED$��Comic Sans MS)�6�   �� 5�      $
��Left=�6    $��1204,1360,0,0q�6;   $��
 469,90 TL��6R   $
��Wrap=�6d   $	��Top=�6x   $��36��6�   $	��138��6�   $��Normal"�6�   $��25(�6�   ���#EDEDED$��Comic Sans MS)�6�   �� 5�      $
��Left=�6    $��58,1601,0,0q�6;   $��KATEGORİLER��6P   $
��Wrap=�6c   $	��Top=�6w   $��49��6�   $	��154��6�   $
��Bold"�6�   $��20(�6�   
���  ��6�   �� 5�      $
��Left=�6    $��58,1641,0,0q�6;   $��Zeytin��6P   $
��Wrap=�6^   $	��Top=�6r   $��23��6�   $	��139��6�   $��Normal"�6�   $��17(�6�   �� 5�      $
��Left=�6    $��58,1669,0,0q�6;   $��Zeytinyağı��6P   $
��Wrap=�6b   $	��Top=�6v   $��23��6�   $	��139��6�   $��Normal"�6�   $��17(�6�   �� 5�      $
��Left=�6    $��58,1697,0,0q�6;   $��Kozmetik��6P   $
��Wrap=�6`   $	��Top=�6t   $��23��6�   $	��139��6�   $��Normal"�6�   $��17(�6�   �� 5�      $
��Left=�6    $��58,1725,0,0q�6;   $��Ev yapımı��6P   $
��Wrap=�6a   $	��Top=�6u   $��23��6�   $	��139��6�   $��Normal"�6�   $��17(�6�   �� 5�      $
��Left=�6    $��58,1753,0,0q�6;   $��	Turşular��6P   $
��Wrap=�6`   $	��Top=�6t   $��23��6�   $	��139��6�   $��Normal"�6�   $��17(�6�   �� 5�      $
��Left=�6    $��58,1781,0,0q�6;   $��Tatlılar&Şekerlemeler��6P   $
��Wrap=�6q   $	��Top=�6�   $��23��6�   $	��164��6�   $��Normal"�6�   $��17(�6�   �� 5�      $
��Left=�6    $��58,1809,0,0q�6;   $��Şarküteri��6P   $
��Wrap=�6a   $	��Top=�6u   $��23��6�   $	��139��6�   $��Normal"�6�   $��17(�6�   �� 5�      $
��Left=�6    $��274,1601,0,0q�6;   $��KURUMSAL��6Q   $
��Wrap=�6a   $	��Top=�6u   $��49��6�   $	��154��6�   $
��Bold"�6�   $��20(�6�   
���  ��6�   �� 5�      $
��Left=�6    $��274,1641,0,0q�6;   $��Anasayfa��6Q   $
��Wrap=�6a   $	��Top=�6u   $��23��6�   $	��139��6�   $��Normal"�6�   $��17(�6�   �� 5�      $
��Left=�6    $��274,1669,0,0q�6;   $��Hakkımızda��6Q   $
��Wrap=�6c   $	��Top=�6w   $��23��6�   $	��139��6�   $��Normal"�6�   $��17(�6�   �� 5�      $
��Left=�6    $��274,1697,0,0q�6;   $��
Mağazalar��6Q   $
��Wrap=�6b   $	��Top=�6v   $��23��6�   $	��139��6�   $��Normal"�6�   $��17(�6�   �� 5�      $
��Left=�6    $��274,1725,0,0q�6;   $!��İletişim ve İsteklerimiz��6Q   $
��Wrap=�6q   $	��Top=�6�   $��23��6�   $	��166��6�   $��Normal"�6�   $��17(�6�   5�      5�      5�      �� 5�   
   $��images/hritem.png��6   $��0,123,10,3465q�6+   $��4��6B   $��1��6V   5�      5�      