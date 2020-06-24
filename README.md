# Trabajo Práctico N°8

### Ejercicio 2

- **Objetos del tipo LinkedList y List, ¿Cuales son las diferencias que tienen?**

La diferencia entre una List<T> y una LinkedList<T> es en cuanto a eficiencia, ya que en cuanto a funcionamiento son similares porque en ambas podemos agregar, quitar o recorrer elementos. La diferencia esta en el costo del funcionamiento, en las listas los elementos se almacenan de forma adyacente lo que implica que al eliminar un elemento todos los que se encontraban despues del eliminado deben moverse un lugar en la memoria, por lo tanto para quitar o agregar constantemente lo menos eficiente es utilizar una List, para estos casos es mucho menos costoso hacer uso de las LinkedList ya que son listas doblemente enlazadas, es decir que sus nodos contienen un enlace al nodo anterior y al siguiente, esto hace que el tratamiento de agregar y quitar elementos sea mucho mas sencillo ya que solo es una redireccion de punteros, ademas los elementos de una LinkedList no se almacenan de forma adyacente en la memoria. 
  
 - **Beneficios de usar una biblioteca, por que pondria una clase en una biblioteca y cuando agregaria directamente la clase en su proyecto**
 
 Las bibliotecas de clases (class library) se utilizan cuando queremos que una o más clases puedan ser reutilizadas en diferentes proyectos, en caso contrario, sólo agregamos la clase al proyecto en el que estamos trabajando.
 
 - **¿Cómo se agrega la referencia a una biblioteca de clase en su proyecto?**
 
 Nos dirijimos a las dependencias de nuestro proyecto, presionamos la opción "add project reference", se abrira una ventana en la cual tenenmos que tildar la libreria que vamos a utilizar, luego agregrar el using con el nombre de la libreria al programa principal. O directamente ir al refactorizador de código y presionar la opción "using NombreLibreria" que hara de forma automatica lo mencionado anteriormente.
