const inputSelectedDate = document.querySelector("#input-selected-date");

inputSelectedDate.value = localStorage.getItem("date");

localStorage.removeItem("date");