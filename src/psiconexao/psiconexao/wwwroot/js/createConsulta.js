const inputDataConsulta = document.querySelector("#input-data-consulta");

inputDataConsulta.value = localStorage.getItem("date");

localStorage.removeItem("date");