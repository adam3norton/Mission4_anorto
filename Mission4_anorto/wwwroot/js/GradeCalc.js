jQuery(function ($) {
$('#submitBtn').on('click', function () {
    console.log("Running!");
    var asgn = +$('#asgn').val();
    var group = +$('#group').val();
    var quiz = +$('#quiz').val();
    var mid = +$('#mid').val();
    var fin = +$('#fin').val();
    var intex = +$('#intex').val();

    var grade = (0.5 * asgn) + (0.1 * group) + (0.1 * quiz) + (0.1 * mid) + (0.1 * fin) + (0.1 * intex);
    var letter = '';

    if (grade >= 94) {
        letter = 'A'
    }
    else if (grade < 94 && grade >= 90) {
        letter = 'A-'
    }
    else if (grade < 90 && grade >= 87) {
        letter = 'B+'
    }
    else if (grade < 87 && grade >= 84) {
        letter = 'B'
    }
    else if (grade < 84 && grade >= 80) {
        letter = 'B-'
    }
    else {
        letter = 'Bad grade ://';
    }

    alert(grade + ': ' + letter);

})

})