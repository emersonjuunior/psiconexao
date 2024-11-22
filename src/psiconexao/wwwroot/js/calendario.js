document.addEventListener('DOMContentLoaded', function () {
    const calendarEl = document.getElementById('calendar');
    const today = new Date().toISOString().split('T')[0];

    const mesesEmPortugues = [
        'Janeiro', 'Fevereiro', 'Março', 'Abril',
        'Maio', 'Junho', 'Julho', 'Agosto', 
        'Setembro', 'Outubro', 'Novembro', 'Dezembro'
    ];

    const diasSemanaEmPortugues = [
        'Domingo', 'Segunda-feira', 'Terça-feira',
        'Quarta-feira', 'Quinta-feira', 'Sexta-feira', 'Sábado'
    ];

    const calendar = new FullCalendar.Calendar(calendarEl, {
        initialView: 'dayGridMonth',
        validRange: {
            start: today,
        },
        selectable: true,

        // Configura o endpoint dos eventos para buscar disponibilidades
        events: '/Disponibilidades/GetDisponibilidades?psicologoId=@Model.UsuarioId',

        dateClick: function (info) {
            const selectedDate = info.dateStr;
            localStorage.setItem("date", selectedDate);
            window.location.href = '/Consultas/Create?date=' + info.dateStr;
        },

        headerToolbar: {
            left: 'prev,next today',
            center: 'title',
            right: 'dayGridMonth,timeGridWeek,timeGridDay'
        },

        titleFormat: {
            month: 'long',
            year: 'numeric'
        },

        dayHeaderContent: (args) => {
            return diasSemanaEmPortugues[args.date.getUTCDay()];
        },

        datesSet: function (dateInfo) {
            const centerDate = new Date(
                (dateInfo.start.getTime() + dateInfo.end.getTime()) / 2
            );
            const monthIndex = centerDate.getMonth();
            const year = centerDate.getFullYear();

            const titleElement = document.querySelector('.fc-toolbar-title');
            titleElement.innerText = `${mesesEmPortugues[monthIndex]} ${year}`;
        },

        buttonText: {
            today: 'Hoje',
            month: 'Mês',
            week: 'Semana',
            day: 'Dia',
            prev: 'Anterior',
            next: 'Próximo'
        }
    });

    calendar.render();
});
