# Proyecto: Visualización de Árbol Binario

Este proyecto es una aplicación de escritorio desarrollada en C# utilizando Windows Forms. Permite la creación, visualización y manipulación de un árbol binario de búsqueda (ABB). Los usuarios pueden agregar, buscar y visualizar los nodos del árbol, así como observar los recorridos preorden, inorden y postorden.

## Características

- **Agregar nodos al árbol binario**: Los usuarios pueden insertar valores enteros en el árbol.
- **Búsqueda de nodos**: Verifica si un valor específico existe en el árbol.
- **Visualización gráfica del árbol**: Representación gráfica del árbol binario en un panel.
- **Recorridos del árbol**:
  - Preorden
  - Inorden
  - Postorden
- **Interfaz interactiva**: Botones y paneles para interactuar con el árbol y visualizar los resultados.
- **Validación de datos**: Manejo de errores para entradas no válidas o duplicadas.

## Requisitos del sistema

- **Lenguaje**: C# 7.3
- **Framework**: .NET Framework 4.7.2
- **IDE recomendado**: Visual Studio 2022

## Instalación

1. Clona este repositorio en tu máquina local:
   https://github.com/Bardodev05/Fase4AndersonMolina.git 
   2. Abre el archivo de solución (`.sln`) en Visual Studio.
3. Asegúrate de tener instalado el .NET Framework 4.7.2.
4. Compila y ejecuta el proyecto.

## Uso

1. **Agregar un nodo**:
   - Ingresa un número entero en el cuadro de texto.
   - Haz clic en el botón "Agregar".
   - Si el valor ya existe, se mostrará un mensaje de advertencia.

2. **Buscar un nodo**:
   - Ingresa un número entero en el cuadro de texto.
   - Haz clic en el botón "Buscar".
   - Se mostrará un mensaje indicando si el valor existe o no en el árbol.

3. **Visualizar recorridos**:
   - Los recorridos preorden, inorden y postorden se muestran automáticamente en los paneles correspondientes después de agregar un nodo.

4. **Visualización gráfica**:
   - El árbol se dibuja automáticamente en el panel principal.

5. **Salir de la aplicación**:
   - Haz clic en el botón "Salir" para cerrar la aplicación.

## Estructura del proyecto

- **`frmPrincipal.cs`**: Contiene la lógica principal de la interfaz de usuario y la interacción con el árbol binario.
- **`ArbolBinario.cs`**: Implementación de la estructura del árbol binario de búsqueda, incluyendo métodos para insertar, buscar y realizar recorridos.
- **`Nodo.cs`**: Representa los nodos individuales del árbol, con referencias a los nodos izquierdo y derecho.
- **Archivos de diseño (`.Designer.cs` y `.resx`)**: Configuración visual de los formularios.

## Ejemplo de funcionamiento

1. Agrega los valores `10`, `5` y `15` al árbol.
2. Visualiza el árbol en el panel principal.
3. Observa los recorridos:
   - Preorden: `10 5 15`
   - Inorden: `5 10 15`
   - Postorden: `5 15 10`
4. Busca el valor `5` para confirmar su existencia.


## Licencia

Este proyecto está bajo la licencia MIT. Consulta el archivo `LICENSE` para más detalles.
