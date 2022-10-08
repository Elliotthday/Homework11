#lang racket

(define elementAt
  (lambda(lst index)
    (cond
      ((not(list? lst)) "This is not a lst")
      ((null? lst) "This is an empty list or index out of bound")
      ((equal? index 0)(car lst))
      (else (elementAt (cdr lst)(- index 1)))
      )
    )
  )

(provide(all-defined-out))