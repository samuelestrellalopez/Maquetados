let form = document.getElementById("form");
let input = document.getElementById("input");
let msg = document.getElementById("msg");
let posts = document.getElementById("posts");

form.addEventListener("submit", (e) => {
  e.preventDefault();
  console.log("button clicked");
  formValidation();
});

let formValidation = () => {
  if (input.value === "") {
    msg.innerHTML = "Post cannot be blank";
    console.log("failure");
  } else if (input.value.length > 255) {
    msg.innerHTML = "Post cannot exceed 255 characters";
    console.log("failure");
  } else {
    console.log("success");
    msg.innerHTML = "";
    acceptData();
  }
};

let data = {};

let acceptData = () => {
  data["text"] = input.value;
  data["date"] = new Date().toLocaleDateString();
  console.log(data);
  createPost();
};

let createPost = () => {
  let truncatedText =
    data.text.length > 255 ? data.text.slice(0, 255) + "..." : data.text;
  posts.innerHTML += `
    <div>
      <p>${truncatedText}</p>
      <p>${data.date}</p> <!-- Muestra la fecha actual aquí -->
      <span class="options">
        <i onClick="editPost(this)" class="fas fa-edit"></i>
        <i onClick="deletePost(this)" class="fas fa-trash-alt"></i>
      </span>
    </div>
  `;
  input.value = "";
};

let deletePost = (e) => {
  e.parentElement.parentElement.remove();
};

let editPost = (e) => {
  input.value = e.parentElement.parentElement.querySelector('p:first-child').innerHTML;
  e.parentElement.parentElement.remove();
};
