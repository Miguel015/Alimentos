window.onload = function () {
    let productosGlobales = "";
    let cantidadTotalGlobal = 0;
    let totalGlobal = 0;

    // 1. Función para obtener los productos del carrito en localStorage.
    function obtenerProductosDelCarrito() {
        let carrito = localStorage.getItem('carrito');
        return carrito ? JSON.parse(carrito) : [];
    }

    // 2. Función para agregar un producto al carrito en localStorage.
    function agregarProductoAlCarrito(producto) {
        let carrito = obtenerProductosDelCarrito();

        // Buscamos si el producto ya está en el carrito.
        let productoExistente = carrito.find(p => p.nombre === producto.nombre);

        if (productoExistente) {
            // Si el producto ya existe, incrementamos su cantidad.
            productoExistente.cantidad += 1;
        } else {
            // Si el producto no existe en el carrito, lo agregamos con cantidad de 1.
            producto.cantidad = 1;
            carrito.push(producto);
        }

        localStorage.setItem('carrito', JSON.stringify(carrito));
    }

    // 3. Función para obtener el número total de productos en el carrito.
    function obtenerNumeroProductos() {
        let carrito = obtenerProductosDelCarrito();
        // Sumamos las cantidades de cada producto.
        let totalProductos = carrito.reduce((total, producto) => total + producto.cantidad, 0);
        return totalProductos;
    }

    // 4. Función para actualizar el contador del carrito.
    function actualizarContadorCarrito() {
        let contador = document.getElementById('cartItemCount');
        if (contador) {
            contador.textContent = obtenerNumeroProductos();
        }
    }

    // 5. Evento que se dispara cuando se clickea el botón para agregar un producto al carrito.
    let btnCart = document.querySelector('.btn-cart');
    if (btnCart) {
        btnCart.addEventListener('click', function () {
            let nombreProducto = document.querySelector('.content-info-Product h2').textContent;
            let precioProducto = document.querySelector('.content-info-Product h4').textContent;
            let descripcionProducto = document.querySelector('.content-info-Product p').textContent;
            let imagenProducto = document.querySelector('.content-image-Product img').getAttribute('src');

            let producto = {
                nombre: nombreProducto,
                precio: precioProducto,
                descripcion: descripcionProducto,
                imagen: imagenProducto
            };

            agregarProductoAlCarrito(producto);
            actualizarContadorCarrito();
            mostrarProductosEnPagina();
        });
    }
    // 6. Función para eliminar un producto del carrito por su nombre.
    function eliminarProductoDelCarrito(nombreProducto) {
        let carrito = obtenerProductosDelCarrito();
        let productoEncontrado = carrito.find(producto => producto.nombre === nombreProducto);

        if (productoEncontrado) {
            // Si la cantidad del producto es más de 1, reduce la cantidad.
            if (productoEncontrado.cantidad > 1) {
                productoEncontrado.cantidad -= 1;
            } else {
                // Si la cantidad es 1, elimina el producto del carrito.
                carrito = carrito.filter(producto => producto.nombre !== nombreProducto);
            }
            localStorage.setItem('carrito', JSON.stringify(carrito));
            mostrarProductosEnPagina();
            actualizarContadorCarrito();

            mostrarProductosEnPagina();
            // Actualizar la información del div "info-buys".
            actualizarInfoBuys();
        }
    }

    // 7. Función para mostrar los productos en la página.
    function mostrarProductosEnPagina() {
        let carrito = obtenerProductosDelCarrito();
        let contenedorProductos = document.getElementById('productosCarrito');

        contenedorProductos.innerHTML = ''; // Limpiamos el contenedor.

        carrito.forEach(producto => {
            // Contenedor principal del producto.
            let productoDiv = document.createElement('div');
            productoDiv.classList.add('producto-item');

            // Contenedor para la imagen.
            let imagenDiv = document.createElement('div');
            imagenDiv.classList.add('imagen-div');

            let productoImagen = document.createElement('img');
            productoImagen.src = producto.imagen;
            productoImagen.alt = producto.nombre;
            imagenDiv.appendChild(productoImagen);

            // Agregamos el contenedor de imagen al contenedor principal.
            productoDiv.appendChild(imagenDiv);

            // Contenedor para la información.
            let infoDiv = document.createElement('div');
            infoDiv.classList.add('info-div');

            // Contenedor específico para Nombre, Precio y Cantidad.
            let informacionProducto = document.createElement('div');
            informacionProducto.classList.add('Information-Producto-Cart');

            let productoNombre = document.createElement('h3');
            productoNombre.textContent = producto.nombre;
            informacionProducto.appendChild(productoNombre);

            let productoPrecio = document.createElement('p');
            productoPrecio.textContent = producto.precio;
            informacionProducto.appendChild(productoPrecio);

            let productoCantidad = document.createElement('p');
            productoCantidad.textContent = "Cantidad: " + producto.cantidad;
            informacionProducto.appendChild(productoCantidad);

            // Agregamos el botón de eliminar.
            let btnEliminar = document.createElement('button');
            btnEliminar.textContent = "";
            btnEliminar.addEventListener('click', function () {
                eliminarProductoDelCarrito(producto.nombre);
            });
            informacionProducto.appendChild(btnEliminar);

            // Agregamos la información al contenedor principal.
            infoDiv.appendChild(informacionProducto);
            productoDiv.appendChild(infoDiv);

            contenedorProductos.appendChild(productoDiv);
        });
    }


    // 8. Actualizar el contador del carrito inmediatamente después de cargar el script.
    setInterval(actualizarContadorCarrito, 1000);

    mostrarProductosEnPagina();

    // 9. Recopilación de los productos a comprar

    // Función para formatear un número en pesos colombianos.
    function formatPriceToCOP(price) {
        return new Intl.NumberFormat('es-CO', {
            style: 'currency',
            currency: 'COP',
            minimumFractionDigits: 0,
            maximumFractionDigits: 0
        }).format(price);
    }

    // Función para obtener la lista de nombres de los productos, separados por coma.
    function obtenerNombresProductos(carrito) {
        return carrito.map(producto => producto.nombre).join(', ');
    }

    // Función para calcular la suma total del carrito.
    function calcularTotal(carrito) {
        return carrito.reduce((suma, producto) => {
            return suma + parseFloat(producto.precio.replace('$', '').replace(/\./g, '').replace(',', '.')) * producto.cantidad; // Removemos el símbolo de moneda, puntos y reemplazamos la coma por punto.
        }, 0);
    }

    // Función para obtener la cantidad total de productos.
    function calcularCantidadTotal(carrito) {
        return carrito.reduce((suma, producto) => {
            return suma + producto.cantidad;
        }, 0);
    }

    function actualizarInfoBuys() {
        let carrito = obtenerProductosDelCarrito();

        let nombres = carrito.length ? obtenerNombresProductos(carrito) : "No hay productos";
        let total = Math.floor(calcularTotal(carrito));
        let cantidadTotal = calcularCantidadTotal(carrito);

        // Actualizando variables globales
        productosGlobales = nombres;
        cantidadTotalGlobal = cantidadTotal;
        totalGlobal = total;

        // Obtenemos el div "info-buys" y actualizamos su contenido.
        let divInfoBuys = document.querySelector('.info-buys');
        if (divInfoBuys) {
            divInfoBuys.innerHTML = `
        <p>Productos: ${nombres}</p>
        <p>Cantidad Total de Productos: ${cantidadTotal}</p>
        <p>Total: ${formatPriceToCOP(total)}</p>
    `;
        }
    }
    // Actualiza el Carrito
    actualizarInfoBuys();

    //--------------------------Inicializar MercadoPago--------------------------//
    // Inicializar MercadoPago
    const mercadopago = new MercadoPago('TEST-f6c952c8-43cd-4641-8c97-f59081670433', {
        locale: 'es-CO'
    });

    async function createPreference() {
        const productDescription = productosGlobales;
        const amount = cantidadTotalGlobal;
        const totalAmount = totalGlobal;

            const payload = {
                Description: productDescription,
                Price: parseFloat(totalAmount),
                Quantity: 1
            };

        console.log('Payload:', payload);  // Línea de depuración añadida

        try {
            const response = await fetch('/api/MercadoPago/create-preference', {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify(payload)
            });

            if (!response.ok) {
                throw new Error('Network response was not ok ' + response.statusText);
            }

            const data = await response.json();
            console.log('Preference data:', data);  // Agregado para depuración
            return data;

        } catch (error) {
            console.error('Error:', error);
        }
    }

    document.getElementById('checkout-btn').addEventListener('click', async () => {
        const preferenceData = await createPreference();

        if (preferenceData && preferenceData.preferenceId && preferenceData.preferenceId.initPoint) {
            console.log('Creating Mercado Pago button...');  // Agregado para depuración

            // Crea un nuevo botón de Mercado Pago
            const mpButton = document.createElement('button');
            mpButton.innerText = 'Pagar con Mercado Pago';
            mpButton.id = 'mp-button';
            mpButton.onclick = function () {
                // Redirecciona al usuario al initPoint cuando se hace clic en el botón de Mercado Pago
                window.location.href = preferenceData.preferenceId.initPoint;
            };


            // Busca el div con la clase 'mercadoPago' y añade el botón dentro de ese div
            const mercadoPagoDiv = document.querySelector('.mercadoPago');
            if (mercadoPagoDiv) {
                mercadoPagoDiv.appendChild(mpButton);
            } else {
                console.error('Div con clase "mercadoPago" no encontrado.');  // Agregado para depuración
            }
        }
    });
}
