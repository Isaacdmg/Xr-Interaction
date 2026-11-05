# Práctica VR Unity 6.5 - Interacción y Simulación Meta XR

## Descripción del Proyecto
Proyecto en Unity 6.5 desarrollado para visores Meta Quest (Android) y pruebas en editor mediante Meta XR Simulator (Windows). La escena contiene una superficie plana con varios objetos 3D colocados a diferentes distancias. El jugador interactúa con el entorno mediante dos tipos de mecanismos: rayo a distancia y contacto directo con la mano.

## Características e Interacciones
- **Desplazamiento y Visión:** Control de cámara e interactores integrado en el prefab `XR Origin (Starter Assets)`. Compatible tanto con gafas reales como con simulación por teclado y ratón en Play Mode.
- **Ray Interactor (Cubo y Esfera):** Selección y agarre a distancia mediante rayo láser. Cambian su material/color dinámicamente al ser seleccionados mediante eventos `Select Entered` y `Select Exited`.
- **Direct Interactor (Objeto Asset Store):** Agarre por contacto directo usando un `Sphere Collider` en modo *Trigger* en el mando. Actualiza un mensaje flotante en la UI espacial (Canvas World Space) al sujetar o soltar el objeto.
- **Entorno:** Plano 3D con componentes físicos (`Rigidbody` y `Collider`) y de interacción (`XR Grab Interactable`) configurados.