rule pdf1 {
    meta:
        description = "Valida si el archivo es un PDF .jpg"
    strings:
        $s1 = {25 50 44 46}
    condition:
        $s1 at 0
}
