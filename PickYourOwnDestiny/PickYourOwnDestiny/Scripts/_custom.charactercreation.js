$(document).ready(function () {
    $('img.characterImage').hide().removeClass('hidden');
})

function RaceButtonHandler(button) {
    document.getElementById('raceSelection').innerHTML = button.value;
    GetCharacterPhoto();
}

function ClassButtonHandler(button) {
    document.getElementById('classSelection').innerHTML = button.value;
    GetCharacterPhoto();
}

function GetCharacterPhoto() {
    var race = document.getElementById('raceSelection').innerHTML;
    var cls = document.getElementById('classSelection').innerHTML;

    $('img.characterImage').hide();

    $('img.characterImage[alt="' + race + cls + '.jpg"]').show();
}