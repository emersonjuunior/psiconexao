document.addEventListener('DOMContentLoaded', function () {
    const calendarEl = document.getElementById('calendar');
    const today = new Date().toISOString().split('T')[0]; // Data atual no formato 'YYYY-MM-DD'

    const calendar = new FullCalendar.Calendar(calendarEl, {
        initialView: 'dayGridMonth', // Exibe o calendário mensalmente

        // Impede marcação em datas anteriores à atual
        validRange: {
            start: today, // Apenas datas a partir de hoje são permitidas
        },

        selectable: true, // Permite selecionar uma data no calendário

        dateClick: function (info) {
            const selectedDate = info.dateStr.split("-").reverse().join("-");
            console.log(selectedDate); // Exibe a data clicada
        },

    });

    calendar.render(); // Renderiza o calendário
});

console.log("js funcionando");