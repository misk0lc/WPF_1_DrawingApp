   M S B A M L   `   `   `  ����  
DrawingApp    DrawingApp.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5        � Title$  Egyszerű Rajzoló��5      $	��450��6   $	��800��6+   .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      .+�5
   
   �� 
�������$��0��6%   �� 5   
    �� Orientation$ 
Horizontal=�6   $��Center=�6.   $��Center=�6I   .+�5      �� $��Vastagság: ��6   $��0��6+   �� 5      -   5         ��Name$ LineWidthSlider��5       � Minimum$ 2Q�6.    � Maximum$ 32Q�6:    � Value$ 2Q�6G    �� IsSnapToTickEnabled$
 True��6Q   $��0��6l   $	��200��6y   6�   �� 5      $��Válassz színt: ��6   �� 5      -   5         ��Name$ ColorPicker��5      $��65��6\   .@�5      �� $��Fekete��6   
	 � Tag$	 black��60   
 �� 
IsSelected$

 True��6<   �� 5      $��Piros��6   $		 red��6/   �� 5      $
��Kék��6   $
	 blue��6-   �� 5      $��Zöld��6   $	 green��6.   5      �� 5      -   5        $��Törlés��5      $��10,0,0,0q�6:   5      �� 5   
   -   5        $��MyCanvas��5      
�������$��1��6�   5      5      