class SimpleIterator {
    private current: number;
    private end: number;

    constructor(start: number, end: number) {
        this.current = start;
        this.end = end;
    }

    public next(): IteratorResult<number> {
        if (this.current <= this.end) {
            return { value: this.current++, done: false };
        } else {
            return { value: null, done: true };
        }
    }
}

const iterator = new SimpleIterator(1, 5);

let result = iterator.next();
while (!result.done) {
    console.log(result.value);
    result = iterator.next();
}