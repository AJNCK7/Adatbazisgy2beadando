create or replace function sf_check_zipcode
(
    p_zipcode in owners.zipcode%type
)
return int
deterministic
as
    v_zipcode_char char(1);
    v_i int;
begin
    if p_zipcode is null then
        return 0;
    end if;
    
    if length(trim(p_zipcode)) = 4 then
        v_i := 1;
        while v_i <= 4 loop
            v_zipcode_char := substr(p_zipcode, v_i, 1);
            if not (ascii('0') <= ascii(v_zipcode_char) and ascii(v_zipcode_char) <= ascii('9')) then
            return 0;
            end if;
            v_i := v_i + 1;
        end loop;
        return 1;
    end if;
    return 0;
end sf_check_zipcode;
        