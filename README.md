# Ejemplo_WPF_MVVM

Ejemplo de aplicación de escritorio con WPF y el patrón MVVM que hice en noviembre de 2022 en el ciclo de DAM. Es una pequeña gestión de una tienda con tres secciones: artículos, dependientes y ventas. Cada una tiene su lista, su página de información, su edición y su formulario para añadir.

## Qué hay

- `ProyectoWPF/Model` con los modelos de artículos, dependientes y ventas.
- `ProyectoWPF/View` con las páginas XAML de cada sección, navegando entre ellas con `Inicio` y `MainWindow`.
- `ProyectoWPF/Core` con los comandos (`RelayCommand` y `ParamCommand`) y las interfaces auxiliares.
- `ProyectoWPF/Connectors/DbConnector.cs`, que de momento devuelve unos artículos de ejemplo escritos a mano en lugar de leer de una base de datos.

## Cómo abrirlo

Necesita Windows y Visual Studio con la carga de trabajo de escritorio de .NET. Abre `ProyectoWPF.sln` y ejecútalo; usa .NET Framework 4.7.2. No lo he compilado desde el entorno en el que escribí este README, así que no puedo garantizar que compile sin tocar nada con tu versión de Visual Studio.

---

# Ejemplo_WPF_MVVM (English)

A desktop application example using WPF and the MVVM pattern that I made in November 2022 during my DAM vocational course. It is a small shop management app with three sections: articles, shop assistants and sales. Each one has a list, an information page, an edit page and an add form.

## What's inside

- `ProyectoWPF/Model` with the article, assistant and sales models.
- `ProyectoWPF/View` with the XAML pages for each section, navigated from `Inicio` and `MainWindow`.
- `ProyectoWPF/Core` with the commands (`RelayCommand` and `ParamCommand`) and helper interfaces.
- `ProyectoWPF/Connectors/DbConnector.cs`, which for now returns a few hardcoded sample articles instead of reading from a database.

## Opening it

It needs Windows and Visual Studio with the .NET desktop workload. Open `ProyectoWPF.sln` and run it; it targets .NET Framework 4.7.2. I could not compile it in the environment where I wrote this README, so I can't guarantee it builds untouched with your version of Visual Studio.
