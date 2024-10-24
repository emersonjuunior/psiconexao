document.addEventListener('DOMContentLoaded', function () {
    const calendarEl = document.getElementById('calendar');
    const today = new Date().toISOString().split('T')[0]; 

    const calendar = new FullCalendar.Calendar(calendarEl, {
        initialView: 'dayGridMonth', // Exibe o calendário mensalmente

        //apenas datas a partir de hoje são permitidas
        validRange: {
            start: today, 
        },

        selectable: true, // Permite selecionar uma data no calendário

        dateClick: function (info) {
            const selectedDate = info.dateStr
            localStorage.setItem("date", selectedDate);
        },

    });

    calendar.render();
});


