   M S B A M L   `   `   `  ����B  >WpfApp4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp4WpfApp4  5   	       WpfApp4.VictoryWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp4     5   	     � 
ResizeMode$  NoResize=�5   	    � AllowsTransparency .   � Icon$D >C:\Users\maksi\source\repos\WpfApp4\WpfApp4\Resources\rich.png��5
   	    � Title$  ��5   	   $	��650��6   $	��500��6   ��5      �� 5   
    �� 
StartPoint$	 0,0&�6    �� EndPoint$	 1,1&�6/   .��5      �  � Color$ 	#FFB3E5FC��6    � Offset$	 0.0Q�6-   5      .��5      � .+�5   
   �� -   5         ��Name$ VictoryMessage��5      $!��Игрок 2 победил��6,   $
��Left=�6C   $	��Top=�6^   $��36(�6v   $��	95,14,0,0q�6�   $
��Bold"�6�   �� 5   
   -   5        	 ��Name$	 Player1Image��5      $K��EC:\Users\maksi\source\repos\WpfApp4\WpfApp4\Resources\pngwing.com.png��6&   
 J� RenderTransformOrigin$
 0.5,0.5&�6u   $��117,49,137,76q�6�   z�5      V� 5      .~�5      ��  �� ScaleY$ -1Q�6%   �� 5      �� 5       �� Angle$ 180.566Q�6&   T� 5       T� X$ 2Q�6)   5      5      �� 5   
   -   5        $	 Player2Image��5      $L��FC:\Users\maksi\source\repos\WpfApp4\WpfApp4\Resources\pngwing.com2.png��6&   $
 0.5,0.5&�6v   $��117,49,137,76q�6�   z�5       V� 5!      .~�5"      �� $ -1Q�6%   �� 5#      �� 5$      $ 180.566Q�6&   T� 5%      $ 2Q�6)   5&      5(      �� 5)   
   -   5        $��← Вернуться��5)      $��Center=�6'   $��Bottom=�6D   $��0,0,0,50q�6_   $��40��6q   $	��170��6}   $��20(�6�   $
��10,5q�6�   ��5*      �� 5+       �� 
TargetType" ��6   .�5,      ��  �� Property � �� �� Value �	#FF03A9F463   �� 5-       � ��
 �����63   �� 5.       � ��$
 Bold"�63   �� 5/       � ��$ 0q�68   �� 50       � ��$
 10,5q�60   �� 51       � ��$ Center=�6C   �� 52       � ��$ Center=�6A   �� 53       � �� 54      �� 55       �� 
TargetType" ��6.   .R�56   "   � .+�57   &   �� #��z��6-    �� CornerRadius$ 20��6W   ._�58   *   �� $��Center=�6;   $��Center=�6X   59   '   5:   #   5;      5=       �� Triggers 5>      P� 5?       P� Property �@J�IsMouseOver P� Value . . �5@      ��  � �� �	#FF0288D16;   5A      P� 5B       � �� . . �5C      ��  � �� �	#FF01579B6;   5D      5F      5H      5I      5J      