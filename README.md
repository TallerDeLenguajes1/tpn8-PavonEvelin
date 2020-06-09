# Trabajo Práctico N°8

### Ejercicio 2

- **Objetos del tipo LinkedList y List, ¿Cuales son las diferencias que tienen?**

La diferencia entre una List<T> y una LinkedList<T> es en cuanto a eficiencia, ya que en cuanto a funcionamiento son similares porque en ambas podemos agregar, quitar o recorrer elementos. La diferencia esta en el costo del funcionamiento, en las listas los elementos se almacenan de forma adyacente lo que implica que al eliminar un elemento todos los que se encontraban despues del eliminado deben moverse un lugar en la memoria, por lo tanto para quitar o agregar constantemente lo menos eficiente es utilizar una List, para estos casos es mucho menos costoso hacer uso de las LinkedList ya que son listas doblemente enlazadas, es decir que sus nodos contienen un enlace al nodo anterior y al siguiente, esto hace que el tratamiento de agregar y quitar elementos sea mucho mas sencillo ya que solo es una redireccion de punteros, ademas los elementos de una LinkedList no se almacenan de forma adyacente en la memoria. 
