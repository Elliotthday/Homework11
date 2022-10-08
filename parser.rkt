#lang racket
(require "other.rkt")

(define neo-parser
  (lambda (neo-code)
    (cond
      ((number? neo-code) (list 'num-exp neo-code))
      ((symbol? neo-code) (list 'var-exp neo-code))
      ((equal? (car neo-code) 'bool);Branch to parse (bool op num1 num2) into (bool-exp op(neo-exp) (neo-exp))
        (if (equal? (length neo-code) 3)
            (list 'bool-exp (elementAt neo-code 1) (neo-parser (caddr neo-code)) '())
        (cons 'bool-exp (cons (cadr neo-code) (map neo-parser (cddr neo-code))))))
      ;(math op num1 num2) > (math-exp op (neo-exp) (neo-exp))
      ((equal? (car neo-code) 'math)
       (list 'math-exp (cadr neo-code)
             (neo-parser (caddr neo-code))
             (neo-parser (cadddr neo-code))))
      ((equal? (car neo-code) 'ask);Decision branch
       (cons 'ask-exp
             (map neo-parser (cdr neo-code))))
      ;(function (x y z,...) x)
      ((equal? (car neo-code) 'function)
       (list 'func-exp
             (list 'params (cadr neo-code));passes everything in function(x y z) instead of caadr which would pass just x
             (list 'body-exp (neo-parser (caddr neo-code)))))
      ((equal? (car neo-code) 'call)
       (list 'app-exp
             (neo-parser (cadr neo-code))
             (neo-parser (caddr neo-code))))
      (else (map neo-parser neo-code)) ;runs neo-parser on everything in the neo-code 
      )
    )
  )

(provide(all-defined-out))