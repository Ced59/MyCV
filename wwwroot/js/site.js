
$(function () {
    // Masquer et démasquer le menu
    $('#sidebarCollapse').on('click', function () {
        $('#sidebar, #content').toggleClass('active');
    });
});

$(function () {
    // Masquer et démasquer le contenu competences
    $('#contentCompetencesCollapse').on('click', function () {
        $('#contentCompetences').slideToggle(1000);
    });
});

$(function () {
    // Masquer et démasquer le contenu competences en cours
    $('#contentInProgressCollapse').on('click', function () {
        $('#contentCompetencesInProgess').slideToggle(1000);
    });
});

$(function () {
    // Masquer et démasquer le contenu competences futures
    $('#contentFutureCollapse').on('click', function () {
        $('#contentCompetencesFuture').slideToggle(1000);
    });
});

$(function () {
    //Calcul de l'age
    var today_date = new Date();
    var today_year = today_date.getFullYear();
    var today_month = today_date.getMonth();
    var today_day = today_date.getDate();
    var birth_year = '1984';
    var birth_month = '10';
    var birth_day = '2';
    var age = today_year - birth_year;

    if (today_month < (birth_month - 1)) {
        age--;
    }
    if (((birth_month - 1) == today_month) && (today_day < birth_day)) {
        age--;
    }

    $("#age").html('<p class="lead text-white mb-0">' + age + ' ans</p>');

});