

//Starting Function For DateTime

        function date_time(id)
        {
        date = new Date;
        year = date.getFullYear();
        month = date.getMonth();
        months = new Array('January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'December');
        d = date.getDate();
        day = date.getDay();
        days = new Array('Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Satuarday');
        h = date.getHours();
        
        if (h > 12)
        {


            hour = h;
            hour = hour - 12;
            Time_Zone = "PM";


        }

        else if (h < 12)
        {


            hour = h;
            Time_Zone = "AM";


        }

        



        m = date.getMinutes();
        if(m<10)
        {
                m = "0"+m;
        }
        s = date.getSeconds();
        if(s<10)
        {
                s = "0"+s;
        }
        result = '' + days[day] + ' ' + months[month] + ' ' + d + ' ' + year + ' ' + hour + ':' + m + ':' + s + ' ' + Time_Zone;
        document.getElementById(id).innerHTML = result;
        setTimeout('date_time("'+id+'");','1000');
        return true;
        }
        