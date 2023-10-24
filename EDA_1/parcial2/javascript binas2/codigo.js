class Pila {
    constructor() {
      this.items = [];
    }
  
    push(element) {
      this.items.push(element);
    }
  
    pop() {
      if (this.isEmpty()) {
        return "Underflow";
      }
      return this.items.pop();
    }
  
    peek() {
      return this.items[this.items.length - 1];
    }
  
    isEmpty() {
      return this.items.length === 0;
    }
  
    replace(oldValue, newValue) {
      this.items = this.items.map(item => (item === oldValue ? newValue : item));
    }
  }
  
  let miPila = new Pila(); // Variable global para almacenar la pila
  
  function mostrarPilaActualizada() {
    const pilaActualizadaDiv = document.getElementById("pilaActualizada");
    pilaActualizadaDiv.innerHTML = `Pila Actualizada: [${miPila.items.join(", ")}]`;
  }
  
  function agregarPila() {
    const pilaInput = document.getElementById("pila").value;
    const elementos = pilaInput.split(" ");
  
    for (let elemento of elementos) {
      miPila.push(parseInt(elemento, 10));
    }
  
    mostrarPilaActualizada(); // Mostrar pila actualizada
  }
  
  function Reemplazar(pila, viejo, nuevo) {
    pila.replace(viejo, nuevo);
    return pila;
  }
  
  function sumarNumerosGrandes(num1, num2) {
    const pila1 = new Pila();
    const pila2 = new Pila();
    const resultadoPila = new Pila();
    let carry = 0;
    let pasos = [];
  
    for (let digito of num1) {
      pila1.push(parseInt(digito, 10));
    }
  
    for (let digito of num2) {
      pila2.push(parseInt(digito, 10));
    }
  
    while (!pila1.isEmpty() || !pila2.isEmpty()) {
      const digito1 = pila1.isEmpty() ? 0 : pila1.pop();
      const digito2 = pila2.isEmpty() ? 0 : pila2.pop();
  
      const suma = digito1 + digito2 + carry;
      carry = Math.floor(suma / 10);
  
      pasos.push({ digito1, digito2, carry, suma });
  
      resultadoPila.push(suma % 10);
    }
  
    if (carry > 0) {
      resultadoPila.push(carry);
      pasos.push({ carry });
    }
  
    let resultado = "";
    while (!resultadoPila.isEmpty()) {
      resultado = resultadoPila.pop() + resultado;
    }
  
    mostrarPasos(pasos);
    mostrarResultado(resultado);
  }
  
  function sumar() {
    const num1 = document.getElementById("num1").value;
    const num2 = document.getElementById("num2").value;
  
    sumarNumerosGrandes(num1, num2);
  }
  
  function mostrarPasos(pasos) {
    const pasosTextarea = document.getElementById("pasos");
    pasosTextarea.value = "Pasos:\n";
  
    for (let i = 0; i < pasos.length; i++) {
      pasosTextarea.value += `Paso ${i + 1}: ${JSON.stringify(pasos[i])}\n`;
    }
  }
  
  function mostrarResultado(resultado) {
    const resultadoDiv = document.getElementById("resultado");
    resultadoDiv.innerHTML = `Resultado: ${resultado}`;
  }
  
  function reemplazar() {
    const valorViejo = parseInt(document.getElementById("valorViejo").value, 10);
    const valorNuevo = parseInt(document.getElementById("valorNuevo").value, 10);
  
    if (!isNaN(valorViejo) && !isNaN(valorNuevo)) {
      miPila = Reemplazar(miPila, valorViejo, valorNuevo);
      mostrarPilaActualizada(); // Mostrar pila actualizada después de reemplazo
    }
  }
  
//Codigo Banco

let ultimoIdCliente = 0; // Variable global para llevar un registro del último ID de cliente

  class ColaBanco {
    constructor() {
      this.clientes = [];
    }
  
    insertarCliente(cliente) {
      cliente.horaLlegada = new Date(); // Obtener la hora del equipo
      this.clientes.push(cliente);
      this.actualizarTabla();
    }
  
    atenderCliente() {
      if (this.clientes.length > 0) {
        const clienteAtendido = this.clientes.shift();
        const horaActual = new Date();
        const tiempoEspera = (horaActual - clienteAtendido.horaLlegada) / (1000 * 60); // Tiempo en minutos
        alert(`Cliente atendido: ${clienteAtendido.nombreCliente}\nTiempo de espera: ${tiempoEspera.toFixed(2)} minutos`);
        this.actualizarTabla();
      } else {
        alert('No hay clientes en la cola.');
      }
    }
  
    actualizarTabla() {
      const tablaBody = document.getElementById("clienteTablaBody"); // Cambia al ID correcto de tbody
      tablaBody.innerHTML = ""; // Limpia el cuerpo de la tabla antes de actualizarla
    
      for (const cliente of this.clientes) {
        const fila = tablaBody.insertRow();
        fila.innerHTML = `
          <td>${cliente.id}</td>
          <td>${cliente.nombreCliente}</td>
          <td>${cliente.tipoMovimiento}</td>
          <td>${cliente.horaLlegada.toLocaleString()}</td>
        `;
      }
    }
    
  }
  
  let colaBanco = new ColaBanco();
  
  function insertarCliente() {
    const nombreCliente = document.getElementById("nombreCliente").value.trim(); // Elimina espacios en blanco
    const tipoMovimiento = document.getElementById("tipoMovimiento").value;
  
    if (nombreCliente === "") {
      alert("Por favor, ingrese un nombre válido.");
      return;
    }
  
    // Incrementa el ID del cliente
    ultimoIdCliente++;
  
    const cliente = {
      id: ultimoIdCliente,
      nombreCliente,
      tipoMovimiento,
      horaLlegada: new Date()
    };
  
    colaBanco.insertarCliente(cliente);
  
    // Limpia el formulario después de insertar un cliente
    document.getElementById("nombreCliente").value = "";
  
    mostrarTablaClientes(); // Mostrar la tabla actualizada
  }
  
  
  function atenderCliente() {
    colaBanco.atenderCliente();
  }

//PINTAR COCHES



  
  function mostrarPractica(numero) {
    const contenidoPractica = document.getElementById("contenidoPractica");
  
    switch (numero) {
      case 8:
        contenidoPractica.innerHTML = `
          <h2>Práctica 8</h2>
          <h1 class="mb-4">Suma de Números Grandes con Pilas</h1>

    <div class="row mb-4">
      <div class="col-md-3">
        <label for="num1">Número 1:</label>
        <input type="text" id="num1" class="form-control" />
      </div>
      <div class="col-md-3">
        <label for="num2">Número 2:</label>
        <input type="text" id="num2" class="form-control" />
      </div>
      <div class="col-md-3">
        <button onclick="sumar()" class="btn btn-primary mt-4">Sumar</button>
      </div>
    </div>

    <h2 class="mb-3">Pasos:</h2>
    <textarea id="pasos" class="form-control mb-4" rows="10" readonly></textarea>

    <h2>Resultado:</h2>
    <div id="resultado" class="border p-3 mb-4"></div>

        `;
        break;
      case 9:
        contenidoPractica.innerHTML = `
          <h2>Práctica 9</h2>
          <div class="row mb-4">
          <div class="col-md-6">
            <h2 for="pila">Pila (separada por espacios):</h2>
            <input type="text" id="pila" class="form-control" />
          </div>
          <div class="col-md-2">
            <button onclick="agregarPila()" class="btn btn-success mt-4">Agregar Pila</button>
          </div>
        </div>
    
        <!-- Nuevo campo para mostrar la pila actualizada -->
        <div class="row mb-4">
          <div class="col-md-6">
            <label>Pila Actualizada:</label>
            <div id="pilaActualizada" class="border p-3"></div>
          </div>
        </div>
    
        <div class="row">
          <div class="col-md-3">
            <label for="valorViejo">Valor Viejo:</label>
            <input type="text" id="valorViejo" class="form-control" />
          </div>
          <div class="col-md-3">
            <label for="valorNuevo">Valor Nuevo:</label>
            <input type="text" id="valorNuevo" class="form-control" />
          </div>
          <div class="col-md-3">
            <button onclick="reemplazar()" class="btn btn-primary mt-4">Reemplazar</button>
          </div>
        </div>
      </div>
        `;
        break;
      case 10:
        contenidoPractica.innerHTML = `
        <div class="row">
      
        <div class="col-md-3">
          <label for="nombreCliente">Nombre del Cliente:</label>
          <input type="text" id="nombreCliente" class="form-control" />
        </div>
        <div class="col-md-3">
          <label for="tipoMovimiento">Tipo de Movimiento:</label>
          <select id="tipoMovimiento" class="form-control">
            <option value="Pago de servicio">Pago de servicio</option>
            <option value="Depósito">Depósito</option>
            <option value="Retiro">Retiro</option>
            <option value="Compra de tiempo aire">Compra de tiempo aire</option>
            <option value="Consulta de saldo">Consulta de saldo</option>
          </select>
        </div>
        <div class="col-md-3">
          <button onclick="insertarCliente()" class="btn btn-success mt-4">Insertar Cliente</button>
        </div>
      </div>
      <div class="row">
        <div class="col-md-3">
          <button onclick="atenderCliente()" class="btn btn-primary mt-4">Atender Cliente</button>
        </div>
      </div>
      <table class="table mt-4">
      <thead>
        <tr>
          <th>ID</th>
          <th>Nombre del Cliente</th>
          <th>Tipo de Movimiento</th>
          <th>Hora de Llegada</th>
        </tr>
      </thead>
      <tbody id="clienteTablaBody"></tbody>
    </table>
        `;
        break;
      default:
        contenidoPractica.innerHTML = "";
    }
  }
  