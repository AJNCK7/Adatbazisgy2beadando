set serveroutput on;
declare
    v_call_phonenumber int;
    v_phonenumber owners.phonenumber%type := '+36307211111';
begin
v_call_phonenumber := sf_check_phonenumber(v_phonenumber);
    if v_call_phonenumber = 1 then
        DBMS_OUTPUT.PUT_LINE('Az alábbi phonenumber helyes: '||v_phonenumber);
    ELSE
        DBMS_OUTPUT.PUT_LINE('Az alábbi phonenumber helytelen: '||v_phonenumber);
    END IF;
END;
