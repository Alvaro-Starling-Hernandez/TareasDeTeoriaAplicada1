   M S B A M L   `   `   `  ����I  EProyectoTarea2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ProyectoTarea2.UIProyectoTarea2.UI  5   	   ,    &ProyectoTarea2.UI.Capitulo4_ejercicio5   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ProyectoTarea2.UI     5   	     � Title$  Capitulo4 Ejercicio5��5   	   $	��355��6&   $	��776��63   .��5	      � .+�5
   
   �� $����Hacer un programa que calcule el promedio de edad de un grupo de personas y diga cuál es la de edad más grande y cuál es la más joven��6   $
��Left=�6�   $��	14,10,0,0q�6�   $	��Top=�6�   �� 5   
   $��Edad de la Persona #1:��6   $
��Left=�61   $��	66,53,0,0q�6L   $	��Top=�6_   �� 5   
   $��Edad de la Persona #2:��6   $
��Left=�61   $��	66,88,0,0q�6L   $	��Top=�6_   �� 5   
   $��Edad de la Persona #3:��6   $
��Left=�61   $��
66,119,0,0q�6L   $	��Top=�6`   �� 5   
   $��Edad menor:��6   $
��Left=�6&   $��119,150,0,0q�6A   $	��Top=�6V   �� 5   
   $��Edad mayor:��6   $
��Left=�6&   $��120,182,0,0q�6A   $	��Top=�6V   �� 5   
   -   5         ��Name$ persona1TextBox��5      $
��Left=�6+   $��
201,58,0,0q�6F    �� TextWrapping$
 Wrap=�6[   $	��Top=�6o   $	��120��6�   �� 5   
   -   5        $ perosona2TextBox��5      $
��Left=�6,   $��
201,92,0,0q�6G   $
 Wrap=�6\   $	��Top=�6p   $	��120��6�   �� 5   
   -   5        $ persona3TextBox��5      $
��Left=�6+   $��201,123,0,0q�6F   $
 Wrap=�6\   $	��Top=�6p   $	��120��6�   �� 5   
   -   5        $ edadMenorTextBox��5      $
��Left=�6,   $��201,154,0,0q�6G   $
 Wrap=�6]   $	��Top=�6q   $	��120��6�   �� 5   
   -   5        $ edadMayorTextBox��5      $
��Left=�6,   $��201,187,0,0q�6G   $
 Wrap=�6]   $	��Top=�6q   $	��120��6�   �� 5   
   $��
Promedio: ��6   $
��Left=�6%   $��132,210,0,0q�6@   $	��Top=�6U   �� 5   
   -   5         ��Name$ 
aceptarBtn��5      $��Aceptar��6>   $
��Left=�6P   $��120,272,0,0q�6k   $	��Top=�6�   $��30��6�   $	��101��6�   �� 5   
   -   5        $ 
limpiarBtn��5      $��Limpiar��6>   $
��Left=�6P   $��299,272,0,0q�6k   $	��Top=�6�   $��30��6�   $	��101��6�   �� 5   
   -   5        $ promedioTextBox��5      $
��Left=�6+   $��201,214,0,0q�6F   $
 Wrap=�6[   $	��Top=�6o   $	��120��6�   5      5      