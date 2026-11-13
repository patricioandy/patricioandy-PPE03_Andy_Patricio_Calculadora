# PPE03_Patricio_Andy_Calculadora

#Descripción general
Aplicación de escritorio desarrollada en C# utilizando Windows Forms, diseñada para realizar operaciones aritméticas básicas de forma intuitiva, rápida y con una interfaz gráfica amigable. El sistema incluye validaciones robustas para asegurar la correcta entrada de datos y prevenir errores matemáticos comunes.

#Objetivos
* Proveer una herramienta funcional para cálculos matemáticos básicos (suma, resta, multiplicación y división).
* Aplicar buenas prácticas de programación orientada a objetos y reutilización de código mediante controladores de eventos compartidos en Windows Forms.
* Garantizar la estabilidad de la aplicación mediante la validación estricta de entradas numéricas y control de excepciones.

#Características principales
* Operaciones aritméticas: Soporte para suma, resta, multiplicación y división con números decimales.
* Entrada estructurada: Gestión dinámica de números de múltiples cifras mediante un método centralizado.
* Manejo de errores: Validación contra divisiones entre cero y entradas de texto inválidas utilizando double.TryParse().
* Funciones de control: Botón de borrado total (AC) y botón de retroceso (`Backspace`) para eliminar el último dígito ingresado.

#Tecnologías utilizadas
* Lenguaje: C#
* Framework: .NET (Windows Forms)
* IDE recomendado:** Visual Studio 2022 / Visual Studio Code
* SDK:** .NET SDK (versión compatible con .NET Framework 4.8 o .NET 6.0+)

#Requisitos de instalación
* Sistema operativo Windows (7, 10 u 11).
* Visual Studiocon la carga de trabajo *"Desarrollo de escritorio de .NET"* instalada.
* Git instalado en el equipo para la clonación del repositorio.

#Instrucciones de ejecución
1. Clona el repositorio en tu máquina local ejecutando el siguiente comando en tu terminal:
   ```bash
   git clone [https://github.com/patricioandy/PPE03_Patricio_Andy_Calculadora.git](https://github.com/patricioandy/PPE03_Patricio_Andy_Calculadora.git)