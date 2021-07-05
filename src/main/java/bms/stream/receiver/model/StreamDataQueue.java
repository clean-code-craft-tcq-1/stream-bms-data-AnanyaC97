package bms.stream.receiver.model;

import java.util.AbstractQueue;
import java.util.Collections;
import java.util.Iterator;
import java.util.LinkedList;
import java.util.List;

/**
 * @author Shrinidhi Muralidhar Karanam on 2021-06-28
 */
public class StreamDataQueue<T> extends AbstractQueue<T> {

    private final LinkedList<T> elements;
    private final int queueMaxSize;

    public StreamDataQueue(int queueMaxSize) {
        elements = new LinkedList<T>();
        this.queueMaxSize = queueMaxSize;
    }

    public List<T> getQueue() {
        return Collections.unmodifiableList(elements);
    }

    @Override
    public Iterator<T> iterator() {
        return elements.iterator();
    }

    @Override
    public int size() {
        return elements.size();
    }

    @Override
    public boolean offer(T t) {
        if (t == null) {
            return false;
        }
        if (size() == queueMaxSize) {
            poll();
        }
        elements.add(t);
        return true;
    }

    @Override
    public T poll() {
        Iterator<T> iter = elements.iterator();
        T t = iter.next();
        if (t != null) {
            iter.remove();
            return t;
        }
        return null;
    }

    @Override
    public T peek() {
        return elements.getFirst();
    }
}
