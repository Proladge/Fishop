/*
$(document).ready(function () {

    // Устанавливаем обработчик потери фокуса для всех полей ввода текста
    $('input#FirstName,input#LastName,input#Address,input#Email,input#Phone textarea#message').unbind().blur( function(){

        // Для удобства записываем обращения к атрибуту и значению каждого поля в переменные
        var id = $(this).attr('id');
        var val = $(this).val();

        // После того, как поле потеряло фокус, перебираем значения id, совпадающие с id данного поля
       switch(id)
        {
            // Проверка поля "Имя"
            case 'FirstName':
                var rv_name = /^[a-zA-Zа-яА-Я]+$/; // используем регулярное выражение

                // Eсли длина имени больше 2 символов, оно не пустое и удовлетворяет рег. выражению,
                // то добавляем этому полю класс .not_error,
                // и ниже в контейнер для ошибок выводим слово " Принято", т.е. валидация для этого поля пройдена успешно

                if(val.length > 2 && val != '' && rv_name.test(val))
                {
                    $(this).addClass('not_error');
                    $(this).next('.error-box').text('Принято')
                                              .css('color','green')
                                              .animate({'paddingLeft':'10px'},400)
                                              .animate({'paddingLeft':'5px'},400);
                }

                    // Иначе, мы удаляем класс not-error и заменяем его на класс error, говоря о том что поле содержит ошибку валидации,
                    // и ниже в наш контейнер выводим сообщение об ошибке и параметры для верной валидации

                else
                {
                    $(this).removeClass('not_error').addClass('error');
                    $(this).next('.error-box').html('поле "Имя" обязательно для заполнения<br>, длина имени должна составлять не менее 2 символов<br>, поле должно содержать только русские или латинские буквы')
                                               .css('color','red')
                                               .animate({'paddingLeft':'10px'},400)
                                               .animate({'paddingLeft':'5px'},400);
                }
                break;
            case 'LastName':
                var rv_name = /^[a-zA-Zа-яА-Я]+$/; // используем регулярное выражение

                // Eсли длина имени больше 2 символов, оно не пустое и удовлетворяет рег. выражению,
                // то добавляем этому полю класс .not_error,
                // и ниже в контейнер для ошибок выводим слово " Принято", т.е. валидация для этого поля пройдена успешно

                if (val.length > 2 && val != '' && rv_name.test(val)) {
                    $(this).addClass('not_error');
                    $(this).next('.error-box').text('Принято')
                                              .css('color', 'green')
                                              .animate({ 'paddingLeft': '10px' }, 400)
                                              .animate({ 'paddingLeft': '5px' }, 400);
                }

                    // Иначе, мы удаляем класс not-error и заменяем его на класс error, говоря о том что поле содержит ошибку валидации,
                    // и ниже в наш контейнер выводим сообщение об ошибке и параметры для верной валидации

                else {
                    $(this).removeClass('not_error').addClass('error');
                    $(this).next('.error-box').html('поле "Фамилия" обязательно для заполнения<br>, длина имени должна составлять не менее 2 символов<br>, поле должно содержать только русские или латинские буквы')
                                               .css('color', 'red')
                                               .animate({ 'paddingLeft': '10px' }, 400)
                                               .animate({ 'paddingLeft': '5px' }, 400);
                }
                break;

                // Проверка email
            case 'Email':
                var rv_email = /^([a-zA-Z0-9_.-])+@([a-zA-Z0-9_.-])+\.([a-zA-Z])+([a-zA-Z])+/;
                if(val != '' && rv_email.test(val))
                {
                    $(this).addClass('not_error');
                    $(this).next('.error-box').text('Принято')
                                              .css('color','green')
                                              .animate({'paddingLeft':'10px'},400)
                                              .animate({'paddingLeft':'5px'},400);
                }
                else
                {
                    $(this).removeClass('not_error').addClass('error');
                    $(this).next('.error-box').html('поле "Email" обязательно для заполнения<br>, поле должно содержать правильный email-адрес<br>')
                                               .css('color','red')
                                               .animate({'paddingLeft':'10px'},400)
                                               .animate({'paddingLeft':'5px'},400);
                }
                break;


                // Проверка поля "Сообщение"
            case 'message':
                if(val != '' && val.length < 5000)
                {
                    $(this).addClass('not_error');
                    $(this).next('.error-box').text('Принято')
                                             .css('color','green')
                                             .animate({'paddingLeft':'10px'},400)
                                             .animate({'paddingLeft':'5px'},400);
                }
                else
                {
                    $(this).removeClass('not_error').addClass('error');
                    $(this).next('.error-box').html('поле "Текст письма" обязательно для заполнения')
                                              .css('color','red')
                                              .animate({'paddingLeft':'10px'},400)
                                              .animate({'paddingLeft':'5px'},400);
                }
                break;

        } // end switch(...)

    }); // end blur()

    // Теперь отправим наше письмо с помощью AJAX
    $('form#customerForm').submit(function(e){

        // Запрещаем стандартное поведение для кнопки submit
        e.preventDefault();

        // После того, как мы нажали кнопку "Отправить", делаем проверку,
        // если кол-во полей с классом .not_error равно 3 (так как у нас всего 3 поля), то есть все поля заполнены верно,
        // выполняем наш Ajax сценарий и отправляем письмо адресату

        if($('.not_error').length == 3)
        {
            return true;
        }

            // Иначе, если количество полей с данным классом не равно значению 3, мы возвращаем false,
            // останавливая отправку сообщения в невалидной форме
        else
        {
            return false;
        }

    }); // end submit()

}); // end script */
/*
function CanSubmit(){

    var check = true;
    var Name = document.forms[0].FirstName.value;
    var LastName = document.forms[0].LastName.value;
    var Email = document.forms[0].Email.value;

    var rv_name = /^[a-zA-Zа-яА-Я]+$/;
    var rv_email = /^([a-zA-Z0-9_.-])+@([a-zA-Z0-9_.-])+\.([a-zA-Z])+([a-zA-Z])+/;

    if ( !(Name.length > 2 && Name != '' && rv_name.test(Name)) ) {
        check = false
        document.getElementById('FirstNameErr').innerHTML = '<span style="color:red; font-weight: 800; font-size:20px;">!!!</span>    Длина имени должна составлять не менее 2 символов<br>, поле должно содержать только русские или латинские буквы'; 
    }


    if ( !(LastName.length > 2 && LastName != '' && rv_name.test(LastName)) ) {
      document.getElementById('LastNameErr').innerHTML = '!!!    Длина фамилии должна составлять не менее 2 символов<br>, поле должно содержать только русские или латинские буквы';
      check = false;
     }

    var rv_email = /^([a-zA-Z0-9_.-])+@([a-zA-Z0-9_.-])+\.([a-zA-Z])+([a-zA-Z])+/;

   if (Email != '' && rv_email.test(Email))
        return true;
    else {
        document.getElementById('EmailErr').innerHTML = ''
        return false;
    }  

        

    return check;

    };  */



function showError(container, errorMessage) {
      container.className = 'error';
      var msgElem = document.createElement('td');
      msgElem.className = "error-message";
      msgElem.innerHTML = '<span style="font-weight:800;color:red">!</span>' + errorMessage;
      container.appendChild(msgElem);
    }

    function resetError(container) {
      
      while (container.lastChild.className == "error-message") {
        container.removeChild(container.lastChild);
      }
    }

    function validate(form) {
        var rv_name = /^[a-zA-Zа-яА-Я]+$/;
        var rv_email = /^([a-zA-Z0-9_.-])+@([a-zA-Z0-9_.-])+\.([a-zA-Z])+([a-zA-Z])+/;

        console.log("VOVKA ");
        var readyToSend = true;
        console.log(form);
      var elems = form.elements;

      resetError(elems.FirstName.parentNode);
      if (!elems.FirstName.value) {
          readyToSend = false;
          showError(elems.FirstName.parentNode, 'Введите имя');
      }
      else if (elems.FirstName.value.length < 2)
      {
          console.log("ДОВЖИНА МЕНЬШЕ 2");
          readyToSend = false;
          showError(elems.FirstName.parentNode, 'Длина имени должна быть более 2 символов');
      }
      else if (!(rv_name.test(elems.FirstName.value))) {
          readyToSend = false;
          showError(elems.FirstName.parentNode, 'поле должно содержать только русские или латинские буквы');
      }


      resetError(elems.LastName.parentNode);
      if (!elems.LastName.value) {
          readyToSend = false;
          showError(elems.LastName.parentNode, ' Введите Фамилию');
          console.log("Фамилия хуйня");
      }
      else if (elems.LastName.value.length < 2) {
          readyToSend = false;
          showError(elems.LastName.parentNode, 'Длина фамилии должна быть более 2 символов');
      }
      else if ( !(rv_name.test(elems.LastName.value)) ) {
          readyToSend = false;
          showError(elems.LastName.parentNode, 'поле должно содержать только русские или латинские буквы');
      }

      resetError(elems.Email.parentNode);
      if (!(rv_email.test(elems.Email.value))) {
          readyToSend = false;
          showError(elems.Email.parentNode, 'Пожалуйста проверте правильность вашего Email');
      }

            
      return readyToSend;
  }
