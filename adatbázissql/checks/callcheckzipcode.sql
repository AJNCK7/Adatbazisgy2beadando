set serveroutput on;
declare
    v_call_zipcode int;
    v_zipcode owners.zipcode%type := '1234';
begin
v_call_zipcode := sf_check_zipcode(v_zipcode);
    if v_call_zipcode = 1 then
        DBMS_OUTPUT.PUT_LINE('Az alábbi zipcode helyes: '||v_zipcode);
    ELSE
        DBMS_OUTPUT.PUT_LINE('Az alábbi zipcode helytelen: '||v_zipcode);
    END IF;
END;
