<Window x:Class="CalculatorWPF.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="Калькулятор" 
        Height="500" 
        Width="350"
        ResizeMode="CanMinimize"
        WindowStartupLocation="CenterScreen">
    
    <!-- 
    АТРИБУТЫ ОКНА:
    - Title: заголовок окна
    - Height/Width: размеры окна (не изменяемые пользователем благодаря ResizeMode)
    - ResizeMode="CanMinimize": запрещаем изменение размера, только сворачивание
    - WindowStartupLocation="CenterScreen": окно открывается по центру экрана
    -->
    
    <Window.Resources>
        <!-- 
        СТИЛИ ДЛЯ КНОПОК:
        Определяем переиспользуемые стили, чтобы не дублировать код
        -->
        
        <!-- Стиль для цифровых кнопок -->
        <Style x:Key="NumberButtonStyle" TargetType="Button">
            <Setter Property="FontSize" Value="20"/>
            <Setter Property="FontWeight" Value="Bold"/>
            <Setter Property="Margin" Value="2"/>
            <Setter Property="Background" Value="#FF3B3B3B"/>
            <Setter Property="Foreground" Value="White"/>
            <Setter Property="BorderThickness" Value="0"/>
            <Setter Property="Cursor" Value="Hand"/>
            <Style.Triggers>
                <!-- При наведении мыши кнопка становится светлее -->
                <Trigger Property="IsMouseOver" Value="True">
                    <Setter Property="Background" Value="#FF505050"/>
                </Trigger>
            </Style.Triggers>
        </Style>
        
        <!-- Стиль для кнопок операций (+, -, *, /) -->
        <Style x:Key="OperatorButtonStyle" TargetType="Button">
            <Setter Property="FontSize" Value="20"/>
            <Setter Property="FontWeight" Value="Bold"/>
            <Setter Property="Margin" Value="2"/>
            <Setter Property="Background" Value="#FFFF9500"/>
            <Setter Property="Foreground" Value="White"/>
            <Setter Property="BorderThickness" Value="0"/>
            <Setter Property="Cursor" Value="Hand"/>
            <Style.Triggers>
                <Trigger Property="IsMouseOver" Value="True">
                    <Setter Property="Background" Value="#FFFFB143"/>
                </Trigger>
            </Style.Triggers>
        </Style>
        
        <!-- Стиль для функциональных кнопок (C, ±, %) -->
        <Style x:Key="FunctionButtonStyle" TargetType="Button">
            <Setter Property="FontSize" Value="20"/>
            <Setter Property="FontWeight" Value="Bold"/>
            <Setter Property="Margin" Value="2"/>
            <Setter Property="Background" Value="#FFA5A5A5"/>
            <Setter Property="Foreground" Value="Black"/>
            <Setter Property="BorderThickness" Value="0"/>
            <Setter Property="Cursor" Value="Hand"/>
            <Style.Triggers>
                <Trigger Property="IsMouseOver" Value="True">
                    <Setter Property="Background" Value="#FFBEBEBE"/>
                </Trigger>
            </Style.Triggers>
        </Style>
    </Window.Resources>
    
    <!-- 
    ОСНОВНАЯ РАЗМЕТКА:
    Используем Grid для создания сетки калькулятора
    -->
    <Grid Background="#FF1C1C1E">
        
        <!-- 
        ОПРЕДЕЛЕНИЕ СТРОК:
        Создаем 6 строк:
        - Строка 0: дисплей (высота автоматическая)
        - Строки 1-5: кнопки (равной высоты *)
        -->
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="*"/>
            <RowDefinition Height="*"/>
            <RowDefinition Height="*"/>
            <RowDefinition Height="*"/>
            <RowDefinition Height="*"/>
        </Grid.RowDefinitions>
        
        <!-- 
        ОПРЕДЕЛЕНИЕ СТОЛБЦОВ:
        Создаем 4 столбца одинаковой ширины
        -->
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="*"/>
            <ColumnDefinition Width="*"/>
            <ColumnDefinition Width="*"/>
            <ColumnDefinition Width="*"/>
        </Grid.ColumnDefinitions>
        
        <!-- 
        ДИСПЛЕЙ КАЛЬКУЛЯТОРА:
        - TextBlock для отображения текста
        - Занимает все 4 столбца (Grid.ColumnSpan="4")
        - Выравнивание текста справа
        - Большой шрифт для читаемости
        -->
        <TextBlock x:Name="Display" 
                   Grid.Row="0" 
                   Grid.ColumnSpan="4"
                   Text="0"
                   FontSize="48"
                   FontWeight="Light"
                   Foreground="White"
                   HorizontalAlignment="Right"
                   VerticalAlignment="Center"
                   Margin="10,20,10,20"
                   TextWrapping="Wrap"/>
        
        <!-- 
        ПЕРВАЯ СТРОКА КНОПОК:
        Кнопки: C, ±, %, ÷
        -->
        
        <!-- Кнопка очистки (C) -->
        <Button Content="C" 
                Grid.Row="1" 
                Grid.Column="0"
                Style="{StaticResource FunctionButtonStyle}"/>
        
        <!-- Кнопка смены знака (±) -->
        <Button Content="±" 
                Grid.Row="1" 
                Grid.Column="1"
                Style="{StaticResource FunctionButtonStyle}"/>
        
        <!-- Кнопка процента (%) -->
        <Button Content="%" 
                Grid.Row="1" 
                Grid.Column="2"
                Style="{StaticResource FunctionButtonStyle}"/>
        
        <!-- Кнопка деления (÷) -->
        <Button Content="÷" 
                Grid.Row="1" 
                Grid.Column="3"
                Style="{StaticResource OperatorButtonStyle}"/>
        
        <!-- 
        ВТОРАЯ СТРОКА КНОПОК:
        Кнопки: 7, 8, 9, ×
        -->
        
        <Button Content="7" 
                Grid.Row="2" 
                Grid.Column="0"
                Style="{StaticResource NumberButtonStyle}"/>
        
        <Button Content="8" 
                Grid.Row="2" 
                Grid.Column="1"
                Style="{StaticResource NumberButtonStyle}"/>
        
        <Button Content="9" 
                Grid.Row="2" 
                Grid.Column="2"
                Style="{StaticResource NumberButtonStyle}"/>
        
        <!-- Кнопка умножения (×) -->
        <Button Content="×" 
                Grid.Row="2" 
                Grid.Column="3"
                Style="{StaticResource OperatorButtonStyle}"/>
        
        <!-- 
        ТРЕТЬЯ СТРОКА КНОПОК:
        Кнопки: 4, 5, 6, −
        -->
        
        <Button Content="4" 
                Grid.Row="3" 
                Grid.Column="0"
                Style="{StaticResource NumberButtonStyle}"/>
        
        <Button Content="5" 
                Grid.Row="3" 
                Grid.Column="1"
                Style="{StaticResource NumberButtonStyle}"/>
        
        <Button Content="6" 
                Grid.Row="3" 
                Grid.Column="2"
                Style="{StaticResource NumberButtonStyle}"/>
        
        <!-- Кнопка вычитания (−) -->
        <Button Content="−" 
                Grid.Row="3" 
                Grid.Column="3"
                Style="{StaticResource OperatorButtonStyle}"/>
        
        <!-- 
        ЧЕТВЕРТАЯ СТРОКА КНОПОК:
        Кнопки: 1, 2, 3, +
        -->
        
        <Button Content="1" 
                Grid.Row="4" 
                Grid.Column="0"
                Style="{StaticResource NumberButtonStyle}"/>
        
        <Button Content="2" 
                Grid.Row="4" 
                Grid.Column="1"
                Style="{StaticResource NumberButtonStyle}"/>
        
        <Button Content="3" 
                Grid.Row="4" 
                Grid.Column="2"
                Style="{StaticResource NumberButtonStyle}"/>
        
        <!-- Кнопка сложения (+) -->
        <Button Content="+" 
                Grid.Row="4" 
                Grid.Column="3"
                Style="{StaticResource OperatorButtonStyle}"/>
        
        <!-- 
        ПЯТАЯ СТРОКА КНОПОК:
        Кнопки: 0 (занимает 2 столбца), ., =
        -->
        
        <!-- Кнопка 0 занимает 2 столбца благодаря Grid.ColumnSpan="2" -->
        <Button Content="0" 
                Grid.Row="5" 
                Grid.Column="0"
                Grid.ColumnSpan="2"
                Style="{StaticResource NumberButtonStyle}"/>
        
        <!-- Кнопка десятичной точки (.) -->
        <Button Content="." 
                Grid.Row="5" 
                Grid.Column="2"
                Style="{StaticResource NumberButtonStyle}"/>
        
        <!-- Кнопка равно (=) -->
        <Button Content="=" 
                Grid.Row="5" 
                Grid.Column="3"
                Style="{StaticResource OperatorButtonStyle}"/>
        
    </Grid>
</Window>