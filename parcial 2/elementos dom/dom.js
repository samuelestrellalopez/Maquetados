document.getElementById("demo").innerHTML = "Hello World!";

// <!-- Encuentra el elemento con id=”intro”. -->

const elementoo = document.getElementById("intro");
document.getElementById("intro").innerHTML = "123456";

// c)Cambia el elemento de una etiqueta<p>.

document.getElementById("p1").innerHTML="Samuel";

// <!-- Cambia el contenido de un elemento <h1>. -->

const elemento = document.getElementById("titulo");
elemento.innerHTML = "Nuevo encabezado";

// <!-- En este ejemplo encuentra todos los elementos <p>de uno de tus proyectos .html -->

    const element = document.getElementsByTagName("p");
document.getElementById("ind").innerHTML = 'Reencabezado:' + element[0].innerHTML;

// <!-- Encuentra el elemento con id=”main”y luego encuentra todos los elementos <p>dentro del main. -->

const x = document.getElementById("main");
console.log(x);
const y = x.getElementsByTagName("p");
console.log(y);

// Si desea encontrar todos los elementos con el mismo nombre de clase, use getElementsByClassName().

const w = document.getElementsByClassName("intro");
console.log(w);

// a)Devuelve una lista de todos los elementos<p>con class=”intro”

const X =document.querySelectorAll("p.intro");


// <!-- b)Encuentralos elementos <li>hijos de <ul>, para ello debes crear una lista desordenada con almenos 5 elementos dentro de la lista. -->


const listItems = document.querySelectorAll("ul > li");
console.log(listItems);

// <!-- Encontrar en la consola e imprimir el elemento<h1>. -->

const elementari = document.getElementsByTagName("h1");
console.log(elementari);

// <!-- d)Encontrar la clase listusando querySelector(). -->

const list = document.querySelector(".list");
console.log(list);

// <!-- e)Imprimir los  elementos <li>haciendo  uso  del  cicloforEach()para  iterar  sobre  la  NodeList  e imprimir cada uno de los elementos. -->

console.log("inicio");
const listaDeElementos = document.querySelectorAll("ul > li");
listaDeElementos.forEach((item) => {
    console.log(item);
        
        
});
console.log("fin");

    // f)Uso de la propiedad style para cambiar estilos en línea CSS.
    let cambiarestilo = document.querySelector("h1");
    cambiarestilo.style.color = "Blue"; 

    // )Búsquedade elementos HTML por colecciones de objetos HTML.a)Encuentra el  elemento  de  formulario  con  id=”frm1”,  en  la  colección  de  formularios,  y  muestra todos losvalores de loselementos.
    
    function mostrarValores() {
        var formulario = document.getElementById("frm1");
        var elementos = formulario.elements;

        for (var i = 0; i < elementos.length; i++) {
            var elemento = elementos[i];
            console.log("Nombre del elemento: " + elemento.name);
            console.log("Valor del elemento: " + elemento.value);
            console.log("----------------------");
        }
    }
    // 6)Agregar nuevos elementos al documentoHTML.a)Agregar elementos   al árbol   del   DOM usando losmétodosdocument.createElement(), appendChild()y haciendo uso de lapropiedadtextContent.

   
        let lista1 = document.createElement('ul');
        document.body.appendChild(lista1);

        let elemento1 = document.createElement('li');
        elemento1.textContent = "Flor";
        lista1.appendChild(elemento1);

        let elemento2 = document.createElement('li');
        elemento2.textContent = 'Jaguar';
        lista1.appendChild(elemento2);

    // 7)Usando el método addEventListener() para escuchar eventos en la página.a)Crea un botónen el documento html, dondeal hacer click aparezca un mensaje de alerta.

    const buttonalert = document.getElementById('alert');
    buttonalert.addEventListener('click', () => {
      alert("alerta del botón");
    });
    
    // 8)Validación de formulario.a)Si un campo de formulario (name) esta vacío, se muestra una alerta con un mensaje y devuelve falso para evitar que se envíe y se redireccione a otra página.

    let botonSubmit = document.getElementById('btnSubmit');
    botonSubmit.addEventListener("click", () =>{
        let x = document.forms["form1"]["testtext"].value;
        if(x === ""){
            alert("Se debe completar el nombre");
            return false;
        }
    });
   

    // b)Valida la entrada numéricaquevalide que la entrada sea numéricay que este en un rango entre 1  y  10.Para ello  crea un  input  con  id=”numero”,  un botónde  type=”button”y  que  contenga  el atributo  onclick  donde  se  le  asigne  el  valor  de  la  función. Crea tambiénuna  etiqueta <p>  con id=”demo”. 

    let botonSubmit2 = document.getElementById('btnSubmit2');
    botonSubmit2.addEventListener("click", () =>{
        let x = document.forms["form2"]["testtext2"].value
        if (isNaN(x) || x < 1 || x > 10){
            alert("Entrada no valida");
            return false;
        }else{
            alert("Correcto");
            return false
        }
        return false;
    })  

    // 9)Cambiar el valor de un atributoa)Cambiar el valor de un atributo srcde un elemento <img>.
    function ChangePicture(x) {
        document.getElementById('imagen').src = linksimagin[Math.floor(Math.random() * linksimagin.length)];
        console.log(document.getElementById('imagen').src); }
        const linksimagin = [
            "https://phantom-marca-mx.unidadeditorial.es/0dac9390e3660c80b96a583b69a84ad5/resize/828/f/jpg/mx/assets/multimedia/imagenes/2023/04/03/16805545425507.jpg",
            "https://wwwhatsnew.com/wp-content/uploads/2022/10/Estos-son-los-10-mejores-sistemas-para-pasar-de-texto-a-imagen.jpg",
            "https://cdn.shopify.com/s/files/1/0229/0839/files/bancos_de_imagenes_gratis.jpg?v=1630420628",

        ]


        // 10)Contenido dinámicoa)Agregar la hora actual a una etiqueta con id=”demo”.

        document.getElementById("data").innerHTML = "Fecha: " + Date();




