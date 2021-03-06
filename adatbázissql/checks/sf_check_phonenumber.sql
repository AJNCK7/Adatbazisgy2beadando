create or replace function sf_check_phonenumber
(
    p_phonenumber in owners.phonenumber%type
)
return int
deterministic
as
    v_phonenumber_char char(1);
    v_i int;
begin 
    if p_phonenumber is null then
    return 0;
    end if;
    
    if length(trim(p_phonenumber)) = 12 then
        v_i:= 1;
        while v_i <= 1 loop
            v_phonenumber_char := substr(p_phonenumber, v_i, 1);
            if not (ascii('+') = ascii(v_phonenumber_char)) then
            return 0;
            end if;
            v_i := v_i + 1;
        end loop;
        
        while v_i <= 12 loop
            v_phonenumber_char := substr(p_phonenumber, v_i, 1);
            if not (ascii('0') <= ascii(v_phonenumber_char) and ascii(v_phonenumber_char) <= ascii('9')) then
            return 0;
            end if;
            v_i := v_i + 1;
        end loop;
        return 1;
    end if;
    return 0;
end sf_check_phonenumber;